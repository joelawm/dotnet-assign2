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
    //form class
    public partial class Form1 : Form
    {
        //community objects to hold data
        private static Community currentCommunity;
        private static Community DekalbCommunity;
        private static Community SycamoreCommunity;

        public Form1()
        {
            //intialize the community
            InitializeComponent();
            initailActiveCommunity();
        }

        //sets the communities to active
        private void initailActiveCommunity()
        {
            //dekalb active
            ActiveDekalb activeDekalb = new ActiveDekalb();
            DekalbCommunity = activeDekalb.ActiveDekalb_Files();

            //sycamore active
            ActiveSycamore activeSycamore = new ActiveSycamore();
            SycamoreCommunity = activeSycamore.ActiveSycamore_Files();
        }

        //show the community in eash list box
        private void CommunityListShowing(Community comm)
        {
            //clear the list box
            ComunityListBoxClear();

            //output names
            foreach (var res in comm.Residents)
                PersonListbox.Items.Add(String.Format("{0}\t{1}\t{2}", res.FirstName, (DateTime.Now.Year - res.Birthday.Year), res.Occupation));

            //house output
            ResidenceListbox.Items.Add("House");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as House != null)
                    //resdients output
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(String.Format("{0}  *", property.StreetAddr));
                    else
                        ResidenceListbox.Items.Add(String.Format("{0}", property.StreetAddr));

            //apartment output
            ResidenceListbox.Items.Add("");
            ResidenceListbox.Items.Add("Apartment");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as Apartment != null)
                    //resdients output
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(String.Format("{0}  #  {1}  *", property.StreetAddr, ((Apartment)property).Unit));
                    else
                        ResidenceListbox.Items.Add(String.Format("{0}  #  {1}", property.StreetAddr, ((Apartment)property).Unit));

            //clear the output box
            OutputTextbox.Clear();
            //Display message
            OutputTextbox.Text = "The residents and properties of " + comm.Name + " are now listed.";
        }

        //This function refresh the list box contents without overwriting the messages..... Probably a much better way to this but its 12am
        private void CommunityListShowingRefresh(Community comm)
        {
            //clear the list box
            ComunityListBoxClear();

            //output names
            foreach (var res in comm.Residents)
                PersonListbox.Items.Add(String.Format("{0}\t{1}\t{2}", res.FirstName, (DateTime.Now.Year - res.Birthday.Year), res.Occupation));

            //house output
            ResidenceListbox.Items.Add("House");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as House != null)
                    //resdients output
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(String.Format("{0}  *", property.StreetAddr));
                    else
                        ResidenceListbox.Items.Add(String.Format("{0}", property.StreetAddr));

            //apatment output
            ResidenceListbox.Items.Add("");
            ResidenceListbox.Items.Add("Apartment");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as Apartment != null)
                    //resdients output
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(String.Format("{0}  #  {1}  *", property.StreetAddr, ((Apartment)property).Unit));
                    else
                        ResidenceListbox.Items.Add(String.Format("{0}  #  {1}", property.StreetAddr, ((Apartment)property).Unit));
        }

        //for sale button
        private void ForSaleButton_Click(object sender, EventArgs e)
        {
            //make sure we have item selected
            if (ResidenceListbox.SelectedItem != null)
            {
                string[] streetAddr = ResidenceListbox.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.None);
                //already for sale
                if (streetAddr[streetAddr.Length - 1] == "*")
                {
                    OutputTextbox.Text = streetAddr[0] + " is ALREADY for sale.";
                    return;
                }
                //passes
                ChangePropertyForSale(currentCommunity, streetAddr);
                CommunityListShowing(currentCommunity);
                OutputTextbox.Text = streetAddr[0] + " is now list FOR SALE!";
            }
        }

        //clear the resident for sale 
        private void ClearResidnetsForSale(Community comm, string stAddr)
        {
            //each property
            foreach (var property in comm.Props)
            {
                //countinue if not straddr
                if (property.StreetAddr != stAddr) continue;

                foreach (var res in comm.Residents)
                {
                    foreach (var resId in res.Residencelds)
                    {
                        if (property.Id != resId) continue;
                        //remove if good
                        res.Remove(resId);
                    }
                }
                break;
            }
        }

        //set property for sale
        private void ChangePropertyForSale(Community comm, string[] s)
        {
            //each props in community
            foreach (var property in comm.Props)
            {
                if (s[0] != property.StreetAddr) continue;

                //see if it is a apartment
                if (property is Apartment)
                {
                    if (s[2] == ((Apartment)property).Unit)
                    {
                        property.ForSale = true;
                        break;
                    }
                }
                //set to sale
                else
                {
                    property.ForSale = true;
                    break;
                }
            }
        }

        //clear both list boxes
        private void ComunityListBoxClear()
        {
            PersonListbox.Items.Clear();
            ResidenceListbox.Items.Clear();
        }

        //update the communtiy to current
        private void UpdateCommunity(Community comm)
        {
            //current community
            currentCommunity = comm;
            CommunityListShowing(comm);
        }

        //radio button deklab update communtiy
        private void DekalbRadioButton_Click(object sender, EventArgs e)
        {
            UpdateCommunity(DekalbCommunity);
        }

        //radio button sycamore update community
        private void SycamoreRadioButton_Click(object sender, EventArgs e)
        {
            UpdateCommunity(SycamoreCommunity);
        }

        //click the person list box
        private void PersonListbox_MouseClick(object sender, MouseEventArgs e)
        {
            //split it
            string[] personInfo = PersonListbox.SelectedItem.ToString().Split('\t');

            string[] propertyInfoList = CheckPersonInList(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2]);

            OutputTextbox.Text = String.Format("{0}, Age ({1}), Occupation: {2}, who resides at:\r\n", propertyInfoList[0], personInfo[1], personInfo[2]);
                
            //for all items in the array
            for (int i = 1; i < propertyInfoList.Length; i++)
            {
                if (propertyInfoList[i] == null) break;
                OutputTextbox.AppendText(String.Format("\t{0}\r\n", propertyInfoList[i]));
            }

            //final output
            OutputTextbox.AppendText(String.Format("\r\n### END OUTPUT ###"));
        }

        //check to see if a person is in the list
        private string[] CheckPersonInList(Community comm, string fName, ushort age, string occu)
        {
            //load list
            string[] infoList = new string[10];
            
            //for each resident check
            foreach (var res in comm.Residents)
            {
                //check birthday
                if (!((res.FirstName == fName) &&
                     ((DateTime.Now.Year - res.Birthday.Year) == age) &&
                     (res.Occupation == occu)))
                    continue;
                //full name
                infoList[0] = res.FullName;

                int index = 1;
                foreach (var residentId in res.Residencelds)
                {
                    foreach (var property in comm.Props)
                    {
                        //add apartments to list
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

        //before drop down is hit
        private void Dropdown_Preview(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            //print out
            DisplayResidentAmounts(DekalbCommunity);
            DisplayResidentAmounts(SycamoreCommunity);

            //if community it clicked then display
            if (DekalbRadioButton.Checked == true || SycamoreRadioButton.Checked == true)
            {
                DisplayResidenceDropdown(currentCommunity);
            }
        }

        //output the amount of residents
        private void DisplayResidentAmounts(Community comm)
        {
            OutputTextbox.AppendText("There are " + comm.Population + " people living in " + comm.Name + "." + Environment.NewLine);
        }


        //diplay resident in drop down
        private void DisplayResidenceDropdown(Community comm)
        {
            //remove the unncessary bits
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
            bool IsOk = true;

            //check if the name texbox is empty
            if (String.IsNullOrEmpty(NameTextbox.Text))
            {
                OutputTextbox.AppendText("ERROR: Please enter a name for this resident." + Environment.NewLine);
                IsOk = false;
            }

            //check for a space in the name
            string ischecked = NameTextbox.Text.ToString();
            if (ischecked.Contains(" ") == false)
            {
                OutputTextbox.AppendText("ERROR: You need a space in between the first and the last name." + Environment.NewLine);
                IsOk = false;
            }

            //check if the Occupation textbox is empty
            if (String.IsNullOrEmpty(OccupationTextbox.Text))
            {
                OutputTextbox.AppendText("ERROR: Please enter a occupation for this resident." + Environment.NewLine);
                IsOk = false;
            }

            //compare datetimes
            DateTime dateselected = BirthdayPicker.Value;
            int result = DateTime.Compare(dateselected, DateTime.Now);
            if (result > 0)
            {
                OutputTextbox.AppendText("ERROR: Birthdays cannot be defined from future dates." + Environment.NewLine);
                IsOk = false;
            }

            //check if the residence combobox is empty
            if (string.IsNullOrEmpty(ResidenceCombobox.Text))
            {
                OutputTextbox.AppendText("ERROR: Please select a residence for this new resident to reside at." + Environment.NewLine);
                IsOk = false;
            }

            //check for invalid text in combobox
            if (ResidenceCombobox.Text.Contains("House") == true || ResidenceCombobox.Text.Contains("Apartment") == true || ResidenceCombobox.Text.Contains("-----------------") == true)
            {
                OutputTextbox.AppendText("ERROR: Please select a valid item in the combobox." + Environment.NewLine);
                IsOk = false;
            }

            if (FindPersonId(currentCommunity, NameTextbox.Text.Split(' ')[0], (ushort)(DateTime.Now.Year - dateselected.Year), OccupationTextbox.Text) != 99999)
            {
                OutputTextbox.Text = string.Format("{0} already exist.", NameTextbox.Text);
            }
            else
            {
                ComunityListBoxClear();
                //add function
                AddToProperty(currentCommunity);
            }
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
                                        OutputTextbox.AppendText("You are already a resident here" + Environment.NewLine);
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
                                    OutputTextbox.AppendText("Success! " + fName + " has been added as a resident to " + comm.Name + Environment.NewLine);
                                    CommunityListShowingRefresh(currentCommunity);
                                    added = true;
                                    SnapPerson();
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

        //if garage is checked
        private void GarageCheckbox_Click(object sender, EventArgs e)
        {
            //set visible
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
            //updaete if something is put in box
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
            //clear the output textbox
            OutputTextbox.Clear();

            //error checking
            if(string.IsNullOrEmpty(StreetAddressTextbox.Text))
            {
                OutputTextbox.AppendText("Please, enter the street name for the new property.");
            }
            else
            {
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
                        OutputTextbox.AppendText("Success! A new property at " + stAddr + " has been added to " + comm.Name + "!" + Environment.NewLine);
                        CommunityListShowingRefresh(currentCommunity);
                        //clear everything
                        SnapProperty();
                    }
                    else
                    {
                        //set the properties unit value
                        var unit = AptNumTextbox.Text;

                        Apartment apartment = new Apartment(id, x, y, oId, stAddr, city, state, zip, forSale, bedRoom, bath, sqft, unit);
                        comm.Props.Add(apartment);
                        OutputTextbox.AppendText("Success! A new property at " + stAddr + " has been added to " + comm.Name + "!" + Environment.NewLine);
                        CommunityListShowingRefresh(currentCommunity);
                        //clear everything
                        SnapProperty();
                    }
                }
            }
        }

        //reset textbox
        private void SnapProperty()
        {
            //reset propeties
            StreetAddressTextbox.Clear();
            AptNumTextbox.Clear();
            SquareFtUpDown.Value = 500;
            BedroomsUpDown.Value = 1;
            BathsUpDown.Value = 1;
            FloorsUpDown.Value = 1;
            if(GarageCheckbox.Checked == true)
            {
                GarageCheckbox.Checked = false;
            }
            if(AttachedCheckbox.Checked == true)
            {
                AttachedCheckbox.Checked = false;
            }
            AttachedCheckbox.Visible = false;
        }

        private void SnapPerson()
        {
            //reset persons
            NameTextbox.Clear();
            OccupationTextbox.Clear();
            BirthdayPicker.Value = DateTime.Now;
            ResidenceCombobox.SelectedIndex = -1;
        }

        //buy property button
        private void BuyPropertyButton_Click(object sender, EventArgs e)
        {
            //check if option is selected
            if (ResidenceListbox.SelectedItem != null && PersonListbox.SelectedItem != null)
            {
                //var
                bool forSaleCheck = false;
                string[] propertyInfo = ResidenceListbox.SelectedItem.ToString().Split(new[] { "  " }, StringSplitOptions.None);
                string[] personInfo = PersonListbox.SelectedItem.ToString().Split('\t');

                //remove bits
                if (propertyInfo[propertyInfo.Length - 1] == "*")
                    forSaleCheck = true;

                //make sure its for sale
                if (!forSaleCheck)
                {
                    OutputTextbox.Text = "ERROR: Could not purchase the property at" + propertyInfo[0] + ", as it is not list for sale.";
                }
                else
                {
                    uint personId = FindPersonId(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2]);
                    uint propertyOwnerId = FindPropertyOwnerId(currentCommunity, propertyInfo);

                    //buy property
                    if (BuyProperty(currentCommunity, personId, propertyOwnerId))
                        OutputTextbox.Text = "Sucess! " + personInfo[0] + " has purchase the property at " + propertyInfo[0] + "!";
                    else
                        OutputTextbox.Text = "ERROR: " + personInfo[0] + " already owns the property found at " + propertyInfo[0] + ".";
                }
            }
        }

        //find the owner id
        private uint FindPropertyOwnerId(Community comm, string[] stAddr)
        {
            //each property
            foreach (var property in comm.Props)
            {
                if (property.StreetAddr != stAddr[0]) continue;

                //cehck if apartment
                if (property is Apartment)
                {
                    if (stAddr[2] != ((Apartment)property).Unit) continue;
                }

                //return owner id
                return property.OwnerId;
            }
            return 0;
        }

        //find the person id
        private uint FindPersonId(Community comm, string fName, uint age, string occu)
        {
            foreach (var res in comm.Residents)
            {
                if (!(res.FirstName == fName &&
                     (DateTime.Now.Year - res.Birthday.Year) == age &&
                     res.Occupation == occu))
                    continue;
                //return resident id
                return res.Id;
            }
            return 99999;
        }

        //buy property
        private bool BuyProperty(Community comm, uint personId, uint propertyId)
        {
            //go through residents
            foreach (var res in comm.Residents)
            {
                //if person does nto exists
                if (res.Id != personId) continue;

                //cehck if the person already owns the property
                if (res.Id == propertyId)
                {
                    return false;
                }
                else
                {
                    foreach (var property in comm.Props)
                    {
                        if (property.OwnerId != propertyId) continue;
                        property.ForSale = false;
                        property.OwnerId = res.Id;
                    }
                }
            }
            //update the community
            UpdateCommunity(comm);
            return true;
        }

        //select the person info
        private string[] SelectedPersonInfo()
        {
            //make sure it has item
            if (PersonListbox.SelectedItem != null)
                return PersonListbox.SelectedItem.ToString().Split('\t');

            return null;
        }

        //select property info
        private string[] SelectedPropertyInfo()
        {
            //make sure it has a value
            if (ResidenceListbox.SelectedItem != null)
                return ResidenceListbox.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.None);

            return null;
        }

        //add resident button click
        private void AddResidentButton_Click(object sender, EventArgs e)
        {
            //variables
            string[] personInfo = SelectedPersonInfo();
            string[] propertyInfo = SelectedPropertyInfo();

            //check if null
            if (personInfo != null && propertyInfo != null)
            {   
                bool condiction = AddResidentToProperty(personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2], propertyInfo);

                //if good the set property
                if (condiction)
                    OutputTextbox.Text = string.Format("Success, {0} now resides at the property at {1}.", personInfo[0], propertyInfo[0]);
                else
                    OutputTextbox.Text = string.Format("ERROR: {0} already resides at the prperty at {1}.", personInfo[0], propertyInfo[0]);
            }
            else
                OutputTextbox.Text = "Please select a person and a property address";
        }

        // return condiction: 0 for success; 1 for resident already in property; 2 for property not found;
        private bool AddResidentToProperty(string fName, ushort age, string occu, string[] stAddr)
        {
            //check each resident
            foreach (var res in currentCommunity.Residents)
            {
                if ((res.FirstName == fName) &&
                    (DateTime.Now.Year - res.Birthday.Year) == age &&
                    (res.Occupation == occu))
                {
                    //check each property
                    foreach (var property in currentCommunity.Props)
                    {
                        if (property.StreetAddr == stAddr[0])
                        {
                            //check apartment
                            if (property is Apartment)
                            {
                                if (((Apartment)property).Unit != stAddr[2]) continue;
                            }
                            //return redlds list

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
            //go through each resident
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

                            //remove if res id match
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

        //remove resident button
        private void RemoveResidentButton_Click(object sender, EventArgs e)
        {
            //variables
            string[] personInfo = SelectedPersonInfo();
            string[] propertyInfo = SelectedPropertyInfo();

            //make sure its not null
            if (personInfo != null && propertyInfo != null)
            {
                //remove if success
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
            //clear textbox for display
            OutputTextbox.Clear();

            //make sure not null
            if (ResidenceListbox.SelectedItem == null)
                return;

            string[] propertyInfo = SelectedPropertyInfo();

            //each property
            foreach (var property in currentCommunity.Props)
            {
                //if not equal
                if (property.StreetAddr != propertyInfo[0]) continue;

                if (property is Apartment)
                {
                    if (((Apartment)property).Unit != propertyInfo[2]) continue;
                }

                //output
                OutputTextbox.AppendText("Residents live at " + propertyInfo[0] + ((DekalbRadioButton.Checked) ? ", Dekalb" : ", Sycamore"));

                string name = ""; //blank if no one

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

                        //output each name
                        OutputTextbox.AppendText(res.LastName + ", " + res.FirstName + "\t\t" + (DateTime.Now.Year - res.Birthday.Year) + "\t\t"+  res.Occupation + Environment.NewLine);
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