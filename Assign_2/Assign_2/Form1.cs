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
        private static ActiveSycamore activeSycamore;
        private static ActiveDekalb activeDekalb;
        private static Community currentCommunity;
        private static Community firstcommunity;
        private static Community secondcommunity;

        public Form1()
        {
            InitializeComponent();
        }

        private void CommunityListShowing(Community comm)
        {
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
        }

        private void ComunityListBoxClear()
        {
            PersonListbox.Items.Clear();
            ResidenceListbox.Items.Clear();
        }

        private void DekalbRadioButton_Click(object sender, EventArgs e)
        {
            ComunityListBoxClear();
            activeDekalb = new ActiveDekalb();
            currentCommunity = activeDekalb.ActiveDekalb_Files();
            CommunityListShowing(currentCommunity);
        }

        private void SycamoreRadioButton_Click(object sender, EventArgs e)
        {
            ComunityListBoxClear();
            activeSycamore = new ActiveSycamore();
            currentCommunity = activeSycamore.ActiveSycamore_Files();
            CommunityListShowing(currentCommunity);
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
                foreach (var property in comm.Props)
                    if (property.OwnerId == res.Id)
                        infoList[index++] = property.StreetAddr;
            }

            return infoList;
        }

        private void ResidenceListbox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Dropdown_Preview(object sender, EventArgs e)
        {
            //clear the contents of the textbox
            ClearTextbox();
            //use both communitys and set active
            activeDekalb = new ActiveDekalb();
            firstcommunity = activeDekalb.ActiveDekalb_Files();
            activeSycamore = new ActiveSycamore();
            secondcommunity = activeSycamore.ActiveSycamore_Files();

            //send the data to be gathered and displayer
            OutputTextbox.Text += "There are " + NumberofRes(firstcommunity) + " people living in DeKalb." + Environment.NewLine;
            OutputTextbox.Text += "There are " + NumberofRes(secondcommunity) + " people living in Sycamore." + Environment.NewLine;
            ResidenceCombobox.Items.Clear();

            //check which radio button is hit
            if(DekalbRadioButton.Checked)
            {
                DisplayResidenceDropdown(firstcommunity);
            }
            else if(SycamoreRadioButton.Checked)
            {
                DisplayResidenceDropdown(secondcommunity);
            }
        }

        //clear textbox
        private void ClearTextbox()
        {
            OutputTextbox.Text = string.Empty;
            OutputTextbox.Update();
        }

        //show the number of residents
        private int NumberofRes(Community comm)
        {
            int i = 0;
            foreach (var res in comm.Residents)
            {
                i += 1;
            }
            return i;
        }

        private void DisplayResidenceDropdown(Community comm)
        {
            ResidenceCombobox.Items.Add("House");
            ResidenceCombobox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as House != null)
                    if (property.ForSale)
                        ResidenceCombobox.Items.Add(property.StreetAddr + '*');
                    else
                        ResidenceCombobox.Items.Add(property.StreetAddr);

            ResidenceCombobox.Items.Add("");
            ResidenceCombobox.Items.Add("Apartment");
            ResidenceCombobox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as Apartment != null)
                    if (property.ForSale)
                        ResidenceCombobox.Items.Add(property.StreetAddr + "# " + ((Apartment)property).Unit + '*');
                    else
                        ResidenceCombobox.Items.Add(property.StreetAddr + "# " + ((Apartment)property).Unit);
        }

        private void AddNewResidentButton_Clicked(object sender, EventArgs e)
        {
            //clear the output textbox
            ClearTextbox();
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
                OutputTextbox.Text += "ERROR: Please enter a occupation for this resident." +Environment.NewLine;
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
            if(ResidenceCombobox.Text.Contains("House") == true || ResidenceCombobox.Text.Contains("Apartment") == true || ResidenceCombobox.Text.Contains("-----------------") == true)
            {
                OutputTextbox.Text += "ERROR: Please select a valid item in the combobox." + Environment.NewLine;
                IsOk = false;
            }

            if(IsOk == true)
            {
                //use both communitys and set active
                activeDekalb = new ActiveDekalb();
                firstcommunity = activeDekalb.ActiveDekalb_Files();
                activeSycamore = new ActiveSycamore();
                secondcommunity = activeSycamore.ActiveSycamore_Files();

                //add function
                if (DekalbRadioButton.Checked)
                {
                    AddToProperty(firstcommunity);
                }
                else if (SycamoreRadioButton.Checked)
                {
                    AddToProperty(secondcommunity);
                }
            }
        }

        private void AddToProperty(Community comm)
        {

            foreach(var property in comm.Props)
            {

            }

            //OutputTextbox.Text += "Success." + Name + " has beenadded as a resident to " + comm._name + Environment.NewLine;
        }
    }
}