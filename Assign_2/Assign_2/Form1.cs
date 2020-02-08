﻿/*
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
            DisplayResidentAmounts(comm);
        }

        private void ForSaleButton_Click(object sender, EventArgs e)
        {
            if (ResidenceListbox.SelectedItem != null)
            {
                string[] streetAddr = ResidenceListbox.SelectedItem.ToString().Split(new string[] { "  " }, StringSplitOptions.None);

                if (streetAddr[streetAddr.Length - 1] == "*")
                {
                    OutputTextbox.Text = streetAddr[0] + ", this property is already for sale.";
                    return;
                }
                ClearResidnetsForSale(currentCommunity, streetAddr[0]);
                ChangePropertyForSale(currentCommunity, streetAddr[0]);
                CommunityListShowing(currentCommunity);
                OutputTextbox.Text = streetAddr[0] + " now is for sale.";
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
                        if (property.OwnerId != resId) continue;

                        res.Remove(resId);
                    }
                }
                break;
            }
        }

        private void ChangePropertyForSale(Community comm, string s)
        {
            foreach (var property in comm.Props)
            {
                if (s != property.StreetAddr) continue;
                property.ForSale = true;
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
                        if (property.OwnerId != residentId) continue;

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
            DisplayResidenceDropdown(currentCommunity);
        }

        private void DisplayResidentAmounts(Community comm)
        {
            OutputTextbox.Text += "There are " + currentCommunity.Population + " people living in " + comm.Name + "." + Environment.NewLine;
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
            bool IsOk = true;

            //check if the name texbox is empty
            if (String.IsNullOrEmpty(NameTextbox.Text))
            {
                OutputTextbox.Text += "ERROR: Please enter a name for this resident." + Environment.NewLine;
                IsOk = false;
            }

            //check for a space in the name
            string ischecked = NameTextbox.Text.ToString();
            if (ischecked.Contains(" ") == false)
            {
                OutputTextbox.Text += "ERROR: You need a space in between the first and the last name." + Environment.NewLine;
                IsOk = false;
            }

            //check if the Occupation textbox is empty
            if (String.IsNullOrEmpty(OccupationTextbox.Text))
            {
                OutputTextbox.Text += "ERROR: Please enter a occupation for this resident." + Environment.NewLine;
                IsOk = false;
            }

            //compare datetimes
            DateTime dateselected = BirthdayPicker.Value;
            int result = DateTime.Compare(dateselected, DateTime.Now);
            if (result > 0)
            {
                OutputTextbox.Text += "ERROR: Birthdays cannot be defined from future dates." + Environment.NewLine;
                IsOk = false;
            }

            //check if the residence combobox is empty
            if (string.IsNullOrEmpty(ResidenceCombobox.Text))
            {
                OutputTextbox.Text += "ERROR: Please select a residence for this new resident to reside at." + Environment.NewLine;
                IsOk = false;
            }

            //check for invalid text in combobox
            if (ResidenceCombobox.Text.Contains("House") == true || ResidenceCombobox.Text.Contains("Apartment") == true || ResidenceCombobox.Text.Contains("-----------------") == true)
            {
                OutputTextbox.Text += "ERROR: Please select a valid item in the combobox." + Environment.NewLine;
                IsOk = false;
            }

            if (IsOk == true)
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
                                        OutputTextbox.Text += "You are already a resident here" + Environment.NewLine;
                                        isFound = true;
                                        break;
                                    }
                                }

                                //if not found then its good
                                if (!isFound)
                                {
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
            //clear the output textbox

            OutputTextbox.Clear();
            bool IsOk = true;

            //can add error checking here if need be

            if (IsOk == true)
            {
                //add function
                if (DekalbRadioButton.Checked)
                {
                    //activeDekalb = new ActiveDekalb();
                    //currentCommunity = activeDekalb.ActiveDekalb_Files();
                    AddToProperty(currentCommunity);
                }
                else if (SycamoreRadioButton.Checked)
                {
                    //activeSycamore = new ActiveSycamore();
                    //currentCommunity = activeSycamore.ActiveSycamore_Files();
                    AddToProperty(currentCommunity);
                }
            }
        }

        private void AddAProperty(Community comm)
        {
            //check wether were adding a apartment or a house
            if (String.IsNullOrEmpty(AptNumTextbox.Text))
            {
                // House house = new House(id, x, y, oId, stAddr, city, state, zip, forSale, bedRoom, bath, sqft, garage, aGarage, floor);
                // Community.Props.Add(house);
            }
            else
            {
                //Apartment apartment = new Apartment(id, x, y, oId, stAddr, city, state, zip, forSale, bedRoom, bath, sqft, unit);
                //Community.Props.Add(apartment);
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
                    OutputTextbox.Text = propertyInfo[0] + ", this property is not for sale.";
                }
                else
                {
                    uint personId = FindPersonId(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2]);
                    uint propertyId = FindPropertyId(currentCommunity, propertyInfo[0]);
                    BuyProperty(currentCommunity, personId, propertyId);
                    OutputTextbox.Text = "Sucess, " + personInfo[0] + " has purchase the property at " + propertyInfo[0];
                }
            }
        }

        private uint FindPropertyId(Community comm, string stAddr)
        {
            foreach (var property in comm.Props)
            {
                if (property.StreetAddr != stAddr) continue;

                return property.OwnerId;
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

        private void BuyProperty(Community comm, uint personId, uint propertyId)
        {
            foreach (var property in comm.Props)
            {
                if (property.OwnerId != propertyId) continue;

                foreach (var res in comm.Residents)
                {
                    if (res.Id != personId) continue;

                    res.Add(propertyId);
                    break;
                }
                property.ForSale = false;
                break;
            }
            UpdateCommunity(comm);
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
                if (propertyInfo[propertyInfo.Length - 1] == "*")
                {
                    OutputTextbox.Text = "This property is for sale, please purchase it first";
                    return;
                }

                int condiction = AddResidentToProperty(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2], propertyInfo[0]);
                
                if (condiction == 0)
                    OutputTextbox.Text = string.Format("{0} is adding into {1}.", personInfo[0], propertyInfo[0]);
                else if (condiction == 1)
                    OutputTextbox.Text = string.Format("{0} is already live in {1}.", personInfo[0], propertyInfo[0]);
                else
                    OutputTextbox.Text = string.Format("error: please reboot the program.", personInfo[0], propertyInfo[0]);
            }
            else
                OutputTextbox.Text = "Please select a person and a property address";
        }

        // return condiction: 0 for success; 1 for resident already in property; 2 for property not found;
        private int AddResidentToProperty(Community comm, string fName, ushort age, string occu, string stAddr)
        {
            foreach (var property in comm.Props)
            {
                if (property.StreetAddr != stAddr) continue;

                foreach (var res in comm.Residents)
                {
                    if (!(res.FirstName == fName) &&
                         (DateTime.Now.Year - res.Birthday.Year) == age &&
                         (res.Occupation == occu))
                        continue;

                    foreach (var resId in res.Residencelds)
                        if (resId == property.OwnerId)
                            return 1;

                    res.Add(property.OwnerId);
                    return 0;
                }
            }
            return 2;
        }

        // return option: true for success; false for not found property
        private bool RemoveResidentFromProperty(Community comm, string fName, ushort age, string occu, string stAddr)
        {
            foreach (var property in comm.Props)
            {
                if (property.StreetAddr != stAddr) continue;

                foreach (var res in comm.Residents)
                {
                    if (!(res.FirstName == fName) &&
                         (DateTime.Now.Year - res.Birthday.Year) == age &&
                         (res.Occupation == occu))
                        continue;

                    foreach (var resId in res.Residencelds)
                    {
                        if (resId == property.OwnerId)
                        {
                            res.Remove(property.OwnerId);
                            return true;
                        }
                    }
                    break;
                }
                break;
            }
            return false;
        }

        private void RemoveResidentButton_Click(object sender, EventArgs e)
        {
            string[] personInfo = SelectedPersonInfo();
            string[] propertyInfo = SelectedPropertyInfo();

            if (personInfo != null && propertyInfo != null)
            {
                if (RemoveResidentFromProperty(currentCommunity, personInfo[0], Convert.ToUInt16(personInfo[1]), personInfo[2], propertyInfo[0]))
                    OutputTextbox.Text = string.Format("{0} is removing from {1}", personInfo[0], propertyInfo[0]);
                else
                    OutputTextbox.Text = string.Format("{0} is not live in {1}.", personInfo[0], propertyInfo[0]);
            }
            else
                OutputTextbox.Text = "Please select a person and a property address";
        }
    }
}