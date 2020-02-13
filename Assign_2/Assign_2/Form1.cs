/*
 * Name: Huajian Huang; zid: z1869893
 * Partner: Joseph Meyer; zid: z1788150
 * 
 * CSCI 473 - Assignment 2
 * Function: The main fucntion of this program is to create a piece of software that allows the managment of properties in DeKalb and Sycamore but now with a GUI.
 * 
 */
using System;
using System.Windows.Forms;

namespace Assign_2
{

    public partial class Form1 : Form
    {
        private static Community currentCommunity;
        private static Community DekalbCommunity;
        private static Community SycamoreCommunity;

        public Form1()
        {
            InitializeComponent();
            initailActiveCommunity();
        }

        private void initailActiveCommunity()
        {
            ActiveDekalb activeDekalb = new ActiveDekalb();
            DekalbCommunity = activeDekalb.ActiveDekalb_Files();

            ActiveSycamore activeSycamore = new ActiveSycamore();
            SycamoreCommunity = activeSycamore.ActiveSycamore_Files();
        }

        private void CommunityListShowing(Community comm)
        {
            ComunityListBoxClear();

            foreach (var res in comm.Residents)
                PersonListbox.Items.Add(String.Format("{0}\t{1}\t{2}", res.FirstName, (DateTime.Now.Year - res.Birthday.Year), res.Occupation));

            ResidenceListbox.Items.Add("House");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as House != null)
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(String.Format("{0}  *", property.StreetAddr));
                    else
                        ResidenceListbox.Items.Add(String.Format("{0}", property.StreetAddr));

            ResidenceListbox.Items.Add("");
            ResidenceListbox.Items.Add("Apartment");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as Apartment != null)
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(String.Format("{0}  #  {1}  *", property.StreetAddr, ((Apartment)property).Unit));
                    else
                        ResidenceListbox.Items.Add(String.Format("{0}  #  {1}", property.StreetAddr, ((Apartment)property).Unit));

            OutputTextbox.Clear();
            //Display message
            OutputTextbox.Text = "The residents and properties of " + comm.Name + " are now listed.";
        }

        private void ForSaleButton_Click(object sender, EventArgs e)
        {
            if (ResidenceListbox.SelectedItem != null)
            {
                string[] streetAddr = ResidenceListbox.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.None);

                if (streetAddr[streetAddr.Length - 1] == "*")
                {
                    OutputTextbox.Text = streetAddr[0] + " is ALREADY for sale.";
                    return;
                }
                ChangePropertyForSale(currentCommunity, streetAddr);
                CommunityListShowing(currentCommunity);
                OutputTextbox.Text = streetAddr[0] + " is now list FOR SALE.";
            }
        }

        private void ClearResidnetsForSale(Community comm, string stAddr)
        {
            foreach (var property in comm.Props)
            {
                if (property.StreetAddr != stAddr) continue;

                foreach (var res in comm.Residents)
                {
                    foreach (var resId in res.Residencelds)
                    {
                        if (property.Id != resId) continue;

                        res.Remove(resId);
                    }
                }
                break;
            }
        }

        private void ChangePropertyForSale(Community comm, string[] s)
        {
            foreach (var property in comm.Props)
            {
                if (s[0] != property.StreetAddr) continue;

                if (property is Apartment)
                {
                    if (s[2] == ((Apartment)property).Unit)
                    {
                        property.ForSale = true;
                        break;
                    }
                }
                else
                {
                    property.ForSale = true;
                    break;
                }
            }
        }

        private void ComunityListBoxClear()
        {
            PersonListbox.Items.Clear();
            ResidenceListbox.Items.Clear();
        }

        private void UpdateCommunity(Community comm)
        {
            currentCommunity = comm;
            CommunityListShowing(comm);
        }

        private void DekalbRadioButton_Click(object sender, EventArgs e)
        {
            UpdateCommunity(DekalbCommunity);
        }

        private void SycamoreRadioButton_Click(object sender, EventArgs e)
        {
            UpdateCommunity(SycamoreCommunity);
        }

        private void PersonListbox_MouseClick(object sender, MouseEventArgs e)
        {
            string[] personInfo = PersonListbox.SelectedItem.ToString().Split('\t');

            string[] propertyInfoList = CheckPersonInList(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2]);

            OutputTextbox.Text = String.Format("{0}, {1}, Occupation: {2}\n", propertyInfoList[0], personInfo[1], personInfo[2]);

            for (int i = 1; i < propertyInfoList.Length; i++)
            {
                if (propertyInfoList[i] == null) break;
                OutputTextbox.AppendText(String.Format("\t{0}\n", propertyInfoList[i]));
            }

            OutputTextbox.AppendText(String.Format("### End output ###"));
        }

        private string[] CheckPersonInList(Community comm, string fName, ushort age, string occu)
        {
            string[] infoList = new string[10];
            foreach (var res in comm.Residents)
            {
                if (!((res.FirstName == fName) &&
                     ((DateTime.Now.Year - res.Birthday.Year) == age) &&
                     (res.Occupation == occu)))
                    continue;

                infoList[0] = res.FullName;

                int index = 1;
                foreach (var residentId in res.Residencelds)
                {
                    foreach (var property in comm.Props)
                    {
                        if (property.Id != residentId) continue;

                        if (property is Apartment)
                            infoList[index++] = property.StreetAddr + " # " + ((Apartment)property).Unit;
                        else
                            infoList[index++] = property.StreetAddr;

                        break;
                    }
                }
                break;
            }
            return infoList;
        }

        private void Dropdown_Preview(object sender, EventArgs e)
        {
            if (!(DekalbRadioButton.Checked || SycamoreRadioButton.Checked))
            {
                OutputTextbox.Text = "Please, pick a community first";
                return;
            }
            else
            {
                OutputTextbox.Clear();
                //print out
                DisplayResidentAmounts(DekalbCommunity);
                DisplayResidentAmounts(SycamoreCommunity);

                if (DekalbRadioButton.Checked == true || SycamoreRadioButton.Checked == true)
                {
                    DisplayResidenceDropdown(currentCommunity);
                }
            }
        }

        private void DisplayResidentAmounts(Community comm)
        {
            OutputTextbox.Text += "There are " + comm.Population + " people living in " + comm.Name + "." + Environment.NewLine;
        }

        private void DisplayResidenceDropdown(Community comm)
        {
            ResidenceCombobox.Items.Clear();
            ResidenceCombobox.Items.Add("House");
            ResidenceCombobox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as House != null)
                    ResidenceCombobox.Items.Add(property.StreetAddr);

            ResidenceCombobox.Items.Add("");
            ResidenceCombobox.Items.Add("Apartment");
            ResidenceCombobox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as Apartment != null)
                    ResidenceCombobox.Items.Add(property.StreetAddr + "# " + ((Apartment)property).Unit);
        }

        private void AddNewResidentButton_Clicked(object sender, EventArgs e)
        {
            //clear the output textbox
            OutputTextbox.Clear();

            //check if the name texbox is empty
            if (String.IsNullOrEmpty(NameTextbox.Text))
            {
                OutputTextbox.Text += "ERROR: Please enter a name for this resident." + Environment.NewLine;
                return;
            }

            //check for a space in the name
            string ischecked = NameTextbox.Text.ToString();
            if (ischecked.Contains(" ") == false)
            {
                OutputTextbox.Text += "ERROR: You need a space in between the first and the last name." + Environment.NewLine;
                return;
            }

            //check if the Occupation textbox is empty
            if (String.IsNullOrEmpty(OccupationTextbox.Text))
            {
                OutputTextbox.Text += "ERROR: Please enter a occupation for this resident." + Environment.NewLine;
                return;
            }

            //compare datetimes
            DateTime dateselected = BirthdayPicker.Value;
            int result = DateTime.Compare(dateselected, DateTime.Now);
            if (result > 0)
            {
                OutputTextbox.Text += "ERROR: Birthdays cannot be defined from future dates." + Environment.NewLine;
                return;
            }

            //check if the residence combobox is empty
            if (string.IsNullOrEmpty(ResidenceCombobox.Text))
            {
                OutputTextbox.Text += "ERROR: Please select a residence for this new resident to reside at." + Environment.NewLine;
                return;
            }

            //check for invalid text in combobox
            if (ResidenceCombobox.Text.Contains("House") == true || ResidenceCombobox.Text.Contains("Apartment") == true || ResidenceCombobox.Text.Contains("-----------------") == true)
            {
                OutputTextbox.Text += "ERROR: Please select a valid item in the combobox." + Environment.NewLine;
                return;
            }

            if (FindPersonId(currentCommunity, NameTextbox.Text.Split(' ')[0], (ushort)(DateTime.Now.Year - dateselected.Year), OccupationTextbox.Text) != 99999)
            {
                OutputTextbox.Text = string.Format("{0} already exist.", NameTextbox.Text);
                return;
            }
            
            ComunityListBoxClear();
            //add function
            AddToProperty(currentCommunity);
        }

        private void AddToProperty(Community comm)
        {
            //temp variables
            bool IsGood = false;

            //keep checking and regenerating till a good number is found
            while (IsGood == false)
            {
                //make new random number
                int rnd = GenerateRandomNo();

                foreach (var res in comm.Residents)
                {
                    if (res.Id == rnd)
                    {
                        break;
                    }
                    else
                    {
                        IsGood = true;
                    }
                }

                //double chacking to make sure it was good
                if (IsGood == true)
                {
                    //take in the infroamtion
                    string[] splitstring = NameTextbox.Text.ToString().Split(' ');
                    string fName = splitstring[0];
                    string lName = splitstring[1];
                    string occ = OccupationTextbox.Text.ToString();
                    DateTime dt = BirthdayPicker.Value;
                    //convert int to uint
                    uint id = (uint)(int)rnd;

                    //find the resident id and from address and add it
                    string lookup = ResidenceCombobox.Text;

                    //search for the property and find its id
                    foreach (var property in comm.Props)
                    {
                        bool added = false;
                        //start going through each property listed
                        if (property.StreetAddr == lookup)
                        {

                            bool isFound = false;
                            foreach (var r in comm.Residents)
                            {
                                foreach (var e in r.Residencelds)
                                {
                                    if (e == property.Id)
                                    {
                                        //output
                                        OutputTextbox.Text += "You are already a resident here" + Environment.NewLine;
                                        isFound = true;
                                        break;
                                    }
                                }

                                //if not found then its good
                                if (!isFound)
                                {
                                    //Add the property ID to the residnce list
                                    var resId = property.Id.ToString();

                                    comm.Residents.Add(new Person(id, dt, lName, fName, occ, resId));
                                    OutputTextbox.Text += "Success! " + fName + " has been added as a resident to " + comm.Name + Environment.NewLine;
                                    added = true;

                                    //clear listbox
                                    PersonListbox.Items.Clear();
                                    //Refresh the residence list
                                    CommunityListShowing(comm);
                                    break;
                                }
                            }
                        }
                        if (added) break;
                    }
                }
            }
        }

        //Generate random number
        public int GenerateRandomNo()
        {
            int min = 0;
            int max = 99999;
            Random rdm = new Random();
            return rdm.Next(min, max);
        }

        private void GarageCheckbox_Click(object sender, EventArgs e)
        {
            if (GarageCheckbox.Checked == true)
            {
                AttachedCheckbox.Visible = true;
            }
            else
            {
                AttachedCheckbox.Visible = false;
            }
        }

        private void AptNumTextbox_TextChanged(object sender, EventArgs e)
        {
            if (AptNumTextbox.Text.Length > 0)
            {
                GarageCheckbox.Visible = false;
                FloorsUpDown.Enabled = false;
                FloorsUpDown.Value = 1;
            }
            else
            {
                GarageCheckbox.Visible = true;
                FloorsUpDown.Enabled = true;
            }
        }

        private void GAddPropertyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StreetAddressTextbox.Text))
            {
                OutputTextbox.Text = "Please, enter the street name for the new property.";
                return;
            }

            foreach (var property in currentCommunity.Props)
            {
                if (property.StreetAddr != StreetAddressTextbox.Text) continue;
                OutputTextbox.Text = string.Format("Property, \"{0}\", is already exisit.", StreetAddressTextbox.Text);
                return;
            }

            //clear the output textbox

            OutputTextbox.Clear();

            //can add error checking here if need be

            if (!(DekalbRadioButton.Checked || SycamoreRadioButton.Checked))
            {
                MessageBox.Show("Please, pick a community first");
            }
            else
            {
                //add function
                AddAProperty(currentCommunity);
            }
        }

        private void AddAProperty(Community comm)
        {
            //temp variables
            bool IsGood = false;

            //keep checking and regenerating till a good number is found
            while (IsGood == false)
            {
                //make new random number
                int rnd = GenerateRandomNo();

                foreach (var res in comm.Props)
                {
                    if (res.Id == rnd)
                    {
                        break;
                    }
                    else
                    {
                        IsGood = true;
                    }
                }
                if (IsGood == true)
                {
                    //Start assigning values to the data for merging to new property
                    uint id = (uint)(int)rnd; //convert int to uint
                    uint x = 9999; //we dont plan to use these for this assignment according to rogness
                    uint y = 9999; //we dont plan to use these for this assignment according to rogness
                    uint oId = default(uint); //0 or default value
                    string stAddr = StreetAddressTextbox.Text.ToString();
                    string city = null;
                    string zip = null;
                    if (DekalbRadioButton.Checked)
                    {
                        city = "DeKalb";
                        zip = "60115";
                    }
                    else if (SycamoreRadioButton.Checked)
                    {
                        city = "Sycamore";
                        zip = "60178";
                    }
                    string state = "Illinois";
                    bool forSale = true;
                    decimal tempbr = BedroomsUpDown.Value;
                    uint bedRoom = (uint)(decimal)tempbr;
                    decimal tempb = BathsUpDown.Value;
                    uint bath = (uint)(decimal)tempb;
                    decimal tempsqft = SquareFtUpDown.Value;
                    uint sqft = (uint)(decimal)tempsqft;
                    decimal tempf = FloorsUpDown.Value;
                    uint floor = (uint)(decimal)tempf;



                    //check wether were adding a apartment or a house
                    if (String.IsNullOrEmpty(AptNumTextbox.Text))
                    {
                        bool garage = false;
                        bool aGarage = false;
                        //check if it has a garage
                        if (GarageCheckbox.Checked == true)
                        {
                            garage = true;
                        }
                        if (AttachedCheckbox.Checked == true)
                        {
                            aGarage = true;
                        }

                        House house = new House(id, x, y, oId, stAddr, city, state, zip, forSale, bedRoom, bath, sqft, garage, aGarage, floor);
                        comm.Props.Add(house);

                        //clear listbox
                        PersonListbox.Items.Clear();
                        //Refresh the residence list
                        CommunityListShowing(comm);
                    }
                    else
                    {
                        //set the properties unit value
                        var unit = AptNumTextbox.Text;

                        Apartment apartment = new Apartment(id, x, y, oId, stAddr, city, state, zip, forSale, bedRoom, bath, sqft, unit);
                        comm.Props.Add(apartment);

                        //clear listbox
                        PersonListbox.Items.Clear();
                        //Refresh the residence list
                        UpdateCommunity(comm);
                    }
                }
            }
        }

        private void BuyPropertyButton_Click(object sender, EventArgs e)
        {
            if (ResidenceListbox.SelectedItem != null && PersonListbox.SelectedItem != null)
            {
                bool forSaleCheck = false;
                string[] propertyInfo = ResidenceListbox.SelectedItem.ToString().Split(new[] { "  " }, StringSplitOptions.None);
                string[] personInfo = PersonListbox.SelectedItem.ToString().Split('\t');
                if (propertyInfo[propertyInfo.Length - 1] == "*")
                    forSaleCheck = true;

                if (!forSaleCheck)
                {
                    OutputTextbox.Text = "ERROR: could not purchase the property at" + propertyInfo[0] + "as it is NOT list for sale.";
                }
                else
                {
                    uint personId = FindPersonId(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2]);
                    uint propertyOwnerId = FindPropertyOwnerId(currentCommunity, propertyInfo);

                    if (BuyProperty(currentCommunity, personId, propertyOwnerId))
                        OutputTextbox.Text = "Sucess, " + personInfo[0] + " has purchase the property at " + propertyInfo[0];
                    else
                        OutputTextbox.Text = "ERROR: " + personInfo[0] + " already owns the property found at " + propertyInfo[0];
                }
            }
        }

        private uint FindPropertyOwnerId(Community comm, string[] stAddr)
        {
            foreach (var property in comm.Props)
            {
                if (property.StreetAddr != stAddr[0]) continue;

                if (property is Apartment)
                {
                    if (stAddr[2] != ((Apartment)property).Unit) continue;
                }

                return property.Id;
            }
            return 0;
        }

        private uint FindPersonId(Community comm, string fName, uint age, string occu)
        {
            foreach (var res in comm.Residents)
            {
                if (!(res.FirstName == fName &&
                     (DateTime.Now.Year - res.Birthday.Year) == age &&
                     res.Occupation == occu))
                    continue;

                return res.Id;
            }
            return 99999;
        }

        private bool BuyProperty(Community comm, uint personId, uint propertyId)
        {
            foreach (var res in comm.Residents)
            {
                if (res.Id != personId) continue;

                if (res.Id == propertyId)
                {
                    return false;
                }
                else
                {
                    foreach (var property in comm.Props)
                    {
                        if (property.Id != propertyId) continue;
                        property.ForSale = false;
                        property.OwnerId = res.Id;
                    }
                }
            }
            UpdateCommunity(comm);
            return true;
        }

        private string[] SelectedPersonInfo()
        {
            if (PersonListbox.SelectedItem != null)
                return PersonListbox.SelectedItem.ToString().Split('\t');

            return null;
        }

        private string[] SelectedPropertyInfo()
        {
            if (ResidenceListbox.SelectedItem != null)
                return ResidenceListbox.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.None);

            return null;
        }

        private void AddResidentButton_Click(object sender, EventArgs e)
        {
            string[] personInfo = SelectedPersonInfo();
            string[] propertyInfo = SelectedPropertyInfo();

            if (personInfo != null && propertyInfo != null)
            {
                /*
                if (propertyInfo[propertyInfo.Length - 1] == "*")
                {
                    OutputTextbox.Text = "This property is for sale, please purchase it first";
                    return;
                }
                */

                bool condiction = AddResidentToProperty(personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2], propertyInfo);

                if (condiction)
                    OutputTextbox.Text = string.Format("Success, {0} now resides at the prperty at {1}.", personInfo[0], propertyInfo[0]);
                else
                    OutputTextbox.Text = string.Format("ERROR: {0} already resides at the prperty at {1}.", personInfo[0], propertyInfo[0]);
            }
            else
                OutputTextbox.Text = "Please select a person and a property address";
        }

        // return condiction: 0 for success; 1 for resident already in property; 2 for property not found;
        private bool AddResidentToProperty(string fName, ushort age, string occu, string[] stAddr)
        {
            foreach (var res in currentCommunity.Residents)
            {
                if ((res.FirstName == fName) &&
                    (DateTime.Now.Year - res.Birthday.Year) == age &&
                    (res.Occupation == occu))
                {
                    foreach (var property in currentCommunity.Props)
                    {
                        if (property.StreetAddr == stAddr[0])
                        {
                            if (property is Apartment)
                            {
                                if (((Apartment)property).Unit != stAddr[2]) continue;
                            }

                            foreach (var resId in res.Residencelds)
                            {
                                if (resId == property.Id) return false;
                            }

                            res.Add(property.Id);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // return option: true for success; false for not found property
        private bool RemoveResidentFromProperty(string fName, ushort age, string occu, string[] stAddr)
        {
            foreach (var res in currentCommunity.Residents)
            {
                if ((res.FirstName == fName) &&
                    (DateTime.Now.Year - res.Birthday.Year) == age &&
                    (res.Occupation == occu))
                {
                    foreach (var property in currentCommunity.Props)
                    {
                        if (property.StreetAddr == stAddr[0])
                        {
                            if (property is Apartment)
                            {
                                if (((Apartment)property).Unit != stAddr[2]) continue;
                            }

                            foreach (var resId in res.Residencelds)
                            {
                                if (resId == property.Id)
                                {
                                    res.Remove(property.Id);
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void RemoveResidentButton_Click(object sender, EventArgs e)
        {
            string[] personInfo = SelectedPersonInfo();
            string[] propertyInfo = SelectedPropertyInfo();

            if (personInfo != null && propertyInfo != null)
            {
                if (RemoveResidentFromProperty(personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2], propertyInfo))
                    OutputTextbox.Text = string.Format("Success: {0} no longer resides in the property at {1}", personInfo[0], propertyInfo[0]);
                else
                    OutputTextbox.Text = string.Format("ERROR: {0} doesn't currently reside at the property at {1}.", personInfo[0], propertyInfo[0]);
            }
            else
                OutputTextbox.Text = "Please select a person and a property address";
        }

        private void ResidenceListbox_Click(object sender, EventArgs e)
        {
            if (ResidenceListbox.SelectedItem == null)
                return;

            string[] propertyInfo = SelectedPropertyInfo();

            foreach (var property in currentCommunity.Props)
            {
                OutputTextbox.Text = "";

                if (property.StreetAddr != propertyInfo[0]) continue;

                if (property is Apartment)
                {
                    if (((Apartment)property).Unit != propertyInfo[2]) continue;
                }

                //output
                OutputTextbox.Text += "Residents live at " + propertyInfo[0] + ((DekalbRadioButton.Checked) ? ", Dekalb" : ", Sycamore");

                string name = "N/A";

                //check the residentsd
                foreach (var res in currentCommunity.Residents)
                {
                    if (res.Id != property.OwnerId) continue;

                    name = res.LastName + ", " + res.FirstName;
                    break;
                }

                //output before
                OutputTextbox.AppendText(", owned by " + name + ":" + Environment.NewLine);
                OutputTextbox.AppendText("------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);

                foreach (var res in currentCommunity.Residents)
                {
                    foreach (var resId in res.Residencelds)
                    {
                        if (resId != property.Id) continue;

                        OutputTextbox.AppendText(string.Format("{0}\t{1}\t{2}", res.FullName, (DateTime.Now.Year - res.Birthday.Year), res.Occupation));
                        OutputTextbox.AppendText(Environment.NewLine);
                    }

                }
                break;
            }
            //final output
            OutputTextbox.AppendText(Environment.NewLine);
            OutputTextbox.AppendText(String.Format("### END OUTPUT ###"));
        }
    }
}