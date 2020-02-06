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

    }
}