/*
 * Name: Huajian Huang; zid: z1869893
 * Partner: Joseph Meyer; zid: z1788150
 * 
 * CSCI 473 - Assignment 2
 * Function: The main fucntion of this program is to create a piece of software that allows the managment of properties in DeKalb and Sycamore but now with a GUI.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        protected void CommunityListShowing(Community comm)
        {
            foreach (var res in comm.Residents)
                PersonListbox.Items.Add(res.FirstName +
                                        "\t\t" +
                                        (DateTime.Now.Year - res.Birthday.Year) +
                                        '\t' +
                                        res.Occupation);

            ResidenceListbox.Items.Add("House");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as House != null)
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(property.StreetAddr + '*');
                    else
                        ResidenceListbox.Items.Add(property.StreetAddr);

            ResidenceListbox.Items.Add("");
            ResidenceListbox.Items.Add("Apartment");
            ResidenceListbox.Items.Add("-----------------");
            foreach (var property in comm.Props)
                if (property as Apartment != null)
                    if (property.ForSale)
                        ResidenceListbox.Items.Add(property.StreetAddr + "# " + ((Apartment)property).Unit + '*');
                    else
                        ResidenceListbox.Items.Add(property.StreetAddr + "# " + ((Apartment)property).Unit);
        }

        protected void ComunityListBoxClear()
        {
            PersonListbox.Items.Clear();
            ResidenceListbox.Items.Clear();
        }
        private void DekalbRadioButton_Click(object sender, EventArgs e)
        {
            ComunityListBoxClear();
            activeDekalb = new ActiveDekalb();
            CommunityListShowing(activeDekalb.ActiveDekalb_Files());
        }

        private void SycamoreRadioButton_Click(object sender, EventArgs e)
        {
            ComunityListBoxClear();
            activeSycamore = new ActiveSycamore();
            CommunityListShowing(activeSycamore.ActiveSycamore_Files());
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
            DisplayResidenceDropdown(firstcommunity);
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
    }
}
