using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Meeting_CandM
{
    public partial class Form1 : Form
    {
        //List of meetings
        List<Meeting> meetingList = new List<Meeting>();

        //hardcoded staff members - not participants yet
        Person p1 = new Person("Blake Thompson");
        Person p2 = new Person("Alice Chambers");
        Person p3 = new Person("Lewis Hernaman");
        Person p4 = new Person("Tilly Clarke");
        Person p5 = new Person("Molly Gee");

        //hardcoded locations
        static String[] equipList1 = new String[2]{"Computer", "Projector"};
        Location cantor1 = new Location("Cantor room 1", equipList1);
        static String[] equipList2 = new String[2] {"Apple Mac", "Whiteboard"};
        Location cantor2 = new Location("Cantor room 2", equipList2);
        static String[] equipList3 = new String[3] { "Computer", "Projector", "Specialist Software PC's" };
        Location cantor3 = new Location("Cantor room 3", equipList3);
        static String[] equipList4 = new String[4] { "Computer", "Projector", "Apple Mac", "Whiteboard"};
        Location cantor4 = new Location("Cantor room 4", equipList4);
        static String[] equipList5 = new String[4] { "Projector", "Apple Mac", "Whiteboard", "Specialist Software PC's" };
        Location cantor5 = new Location("Cantor room 5", equipList5);
        static String[] equipList6 = new String[5] { "Computer", "Projector", "Apple Mac", "Whiteboard", "Specialist Software PC's" };
        Location cantor6 = new Location("Cantor room 6", equipList6);

        //meeting creation
        Participant pa1 = new Participant("Blake Thompson", true);
        Participant pa2 = new Participant("Alice Chambers", true);
        Participant pa3 = new Participant("Lewis Hernaman", true);
        Participant pa4 = new Participant("Tilly Clarke", true);
        Participant pa5 = new Participant("Molly Gee", true);

        Meeting m10 = new Meeting();
        List<Participant> pL1 = new List<Participant>();

        public Form1()
        {
            InitializeComponent();
            hardCoded();

            foreach (Meeting m in meetingList)
            {
                meetingsList.Items.Add(m.getMeetingName() +  "\t\t" + m.getSlot());
            }

        }

        public void hardCoded()
        {
            //hardcoded meetings
            Participant pa1 = new Participant("Blake Thompson", true);
            Participant pa2 = new Participant("Alice Chambers", true);
            Participant pa3 = new Participant("Lewis Hernaman", false);
            Participant pa4 = new Participant("Tilly Clarke", false);
            Participant pa5 = new Participant("Molly Gee", false);

            List<Participant> paList1 = new List<Participant>();
            paList1.Add(pa1);
            paList1.Add(pa2);
            paList1.Add(pa5);

            List<String> prefSlot1 = new List<String>();
            prefSlot1.Add("Monday 1pm");
            prefSlot1.Add("Monday 9am");

            List<String> excSlot1 = new List<String>();
            excSlot1.Add("Monday 2pm");
            excSlot1.Add("Monday 10am");

            Meeting m1 = new Meeting(pa1, "Marketing Meeting", "Meeting about upcoming marketing goals", paList1, "Monday 1pm", prefSlot1, excSlot1, cantor6);
            meetingList.Add(m1);

            ///////////////////////////////////////////

            List<Participant> paList2 = new List<Participant>();
            paList1.Add(pa3);
            paList1.Add(pa2);
            paList1.Add(pa4);

            List<String> prefSlot2 = new List<String>();
            prefSlot2.Add("Monday 11am");
            prefSlot2.Add("Monday 9am");

            List<String> excSlot2 = new List<String>();
            excSlot2.Add("Monday 1pm");
            excSlot2.Add("Monday 10am");
            excSlot2.Add("Monday 2pm");

            Meeting m2 = new Meeting(pa1, "Sales Meeting", "Meeting about upcoming sales goals", paList2, "Monday 11am", prefSlot2, excSlot2, cantor2);
            meetingList.Add(m2);

            ////////////////////////////////////////////

            List<Participant> paList3 = new List<Participant>();
            paList3.Add(pa1);
            paList3.Add(pa5);
            paList3.Add(pa4);

            List<String> prefSlot3 = new List<String>();
            prefSlot3.Add("Monday 12pm");
            prefSlot3.Add("Monday 11am");

            List<String> excSlot3 = new List<String>();
            excSlot3.Add("Monday 9am");
            excSlot3.Add("Monday 10am");

            Meeting m3 = new Meeting(pa4, "Client Meeting", "Meeting with Client", paList3, "Monday 12pm", prefSlot3, excSlot3, cantor3);
            meetingList.Add(m3);

        }

        private void bookBut_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = true;

            //meeting to create - pre filled in

            mName.Text = "Group Meeting";
            mDesc.Text = "This will be a whole team meeting, please attend!";
            checkBox6.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox17.Checked = false;
            checkBox16.Checked = false;
            checkBox15.Checked = false;
            checkBox14.Checked = false;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox18.Checked = true;
            checkBox19.Checked = true;
            checkBox20.Checked = true;
            checkBox21.Checked = true;
            checkBox22.Checked = true;
            checkBox7.Checked = true;
            checkBox13.Checked = true;
            checkBox12.Checked = true;
            listBox1.SelectedItem = "Apple Mac";
            listBox2.SelectedItem = "Cantor room 2";
            saveBut.Enabled = false;

            Participant pg1 = new Participant("Blake Thompson", true);
            Participant pg2 = new Participant("Alice Chambers", true);
            Participant pg3 = new Participant("Lewis Hernaman", true);
            Participant pg4 = new Participant("Tilly Clarke", true);
            Participant pg5 = new Participant("Molly Gee", true);

            List<Participant> paListGroupm = new List<Participant>();
            paListGroupm.Add(pg1);
            paListGroupm.Add(pg2);
            paListGroupm.Add(pg3);
            paListGroupm.Add(pg4);
            paListGroupm.Add(pg5);

            List<String> prefSlotGroupm = new List<String>();
            prefSlotGroupm.Add("Monday 1pm");
            prefSlotGroupm.Add("Monday 9am");

            List<String> excSlotGroupm = new List<String>();
            excSlotGroupm.Add("Monday 2pm");
            excSlotGroupm.Add("Monday 10am");

        }

        private void meetingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            button5.Visible = true;


            switch (meetingsList.SelectedIndex)
            {
                case 0:
                    {
                        checkBox23.Checked = false;
                        checkBox25.Checked = false;
                        checkBox26.Checked = false;
                        checkBox27.Checked = false;
                        checkBox30.Checked = false;
                        checkBox31.Checked = false;
                        checkBox33.Checked = false;
                        checkBox34.Checked = false;
                        checkBox24.Checked = true;
                        checkBox28.Checked = true;
                        checkBox29.Checked = true;
                        checkBox32.Checked = true;
                        break;
                    }
                case 1:
                    {
                        checkBox23.Checked = false;
                        checkBox24.Checked = false;
                        checkBox25.Checked = false;
                        checkBox26.Checked = false;
                        checkBox31.Checked = false;
                        checkBox33.Checked = false;
                        checkBox34.Checked = false;
                        checkBox27.Checked = true;
                        checkBox28.Checked = true;
                        checkBox29.Checked = true;
                        checkBox30.Checked = true;
                        checkBox32.Checked = true;
                        break;
                    }
                case 2:
                    {
                        checkBox23.Checked = false;
                        checkBox24.Checked = false;
                        checkBox26.Checked = false;
                        checkBox28.Checked = false;
                        checkBox29.Checked = false;
                        checkBox30.Checked = false;
                        checkBox31.Checked = false;
                        checkBox33.Checked = false;
                        checkBox25.Checked = true;
                        checkBox27.Checked = true;
                        checkBox32.Checked = true;
                        checkBox34.Checked = true;
                        break;
                    }
                case 3:
                    {
                        checkBox23.Checked = false;
                        checkBox24.Checked = false;
                        checkBox25.Checked = false;
                        checkBox26.Checked = false;
                        checkBox28.Checked = false;
                        checkBox31.Checked = false;
                        checkBox32.Checked = false;
                        checkBox33.Checked = false;
                        checkBox34.Checked = false;
                        checkBox27.Checked = true;
                        checkBox30.Checked = true;
                        checkBox29.Checked = true;
                        break;
                    }
                default:
                    {
                        checkBox23.Checked = false;
                        checkBox24.Checked = false;
                        checkBox25.Checked = false;
                        checkBox26.Checked = false;
                        checkBox27.Checked = false;
                        checkBox28.Checked = false;
                        checkBox29.Checked = false;
                        checkBox30.Checked = false;
                        checkBox31.Checked = false;
                        checkBox32.Checked = false;
                        checkBox33.Checked = false;
                        checkBox34.Checked = false;
                        break;
                    }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                m10.addParticipantList(pa1);
                checkBox18.Visible = true;
            }
            else
            {
                m10.removeParticipantList(pa1);
                checkBox18.Visible = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                m10.addParticipantList(pa2);
                checkBox19.Visible = true;
            }
            else
            {
                m10.removeParticipantList(pa2);
                checkBox19.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                m10.addParticipantList(pa3);
                checkBox20.Visible = true;
            }
            else
            {
                m10.removeParticipantList(pa3);
                checkBox20.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                m10.addParticipantList(pa4);
                checkBox21.Visible = true;
            }
            else
            {
                m10.removeParticipantList(pa4);
                checkBox21.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                m10.addParticipantList(pa5);
                checkBox22.Visible = true;
            }
            else
            {
                m10.removeParticipantList(pa5);
                checkBox22.Visible = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                pa1.setImportance(true);
            }
            else
            {
                pa1.setImportance(false);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                pa2.setImportance(true);
            }
            else
            {
                pa2.setImportance(false);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                pa3.setImportance(true);
            }
            else
            {
                pa3.setImportance(false);
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                pa4.setImportance(true);
            }
            else
            {
                pa4.setImportance(false);
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                pa5.setImportance(true);
            }
            else
            {
                pa5.setImportance(false);
            }
        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 9am";

            if (checkBox17.Checked == false)
            {
                if (checkBox6.Checked == true)
                {
                    m10.addPrefList(ps);
                    mReason.Text = "";
                    m10.setSlot("Monday 9am");
                }
                else
                {
                    m10.removePrefList(ps);
                    mReason.Text = "";
                }

            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 10am";

            if (checkBox15.Checked == false)
            {
                if (checkBox8.Checked == true)
                {
                    m10.addPrefList(ps);
                    mReason.Text = "";
                    m10.setSlot("Monday 10am");
                }
                else
                {
                    m10.removePrefList(ps);
                    mReason.Text = "";
                }

            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 11am";

            if (checkBox16.Checked == false)
            {
                if (checkBox7.Checked == true)
                {
                    m10.addPrefList(ps);
                    mReason.Text = "";
                    m10.setSlot("Monday 11am");
                }
                else
                {
                    m10.removePrefList(ps);
                    mReason.Text = "";
                }
            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 12pm";

            if (checkBox14.Checked == false)
            {
                if (checkBox9.Checked == true)
                {
                    m10.addPrefList(ps);
                    mReason.Text = "";
                    m10.setSlot("Monday 12pm");
                }
                else
                {
                    m10.removePrefList(ps);
                    mReason.Text = "";
                }
            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 1pm";

            if (checkBox13.Checked == false)
            {
                if (checkBox10.Checked == true)
                {
                    m10.addPrefList(ps);
                    mReason.Text = "";
                    m10.setSlot("Monday 1pm");
                }
                else
                {
                    m10.removePrefList(ps);
                    mReason.Text = "";
                }
            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 2pm";

            if (checkBox12.Checked == false)
            {
                if (checkBox11.Checked == true)
                {
                    m10.addPrefList(ps);
                    mReason.Text = "";
                    m10.setSlot("Monday 2pm");
                }
                else
                {
                    m10.removePrefList(ps);
                    mReason.Text = "";
                }
            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 9am";

            if (checkBox6.Checked == false)
            {
                if (checkBox17.Checked == true)
                {
                    m10.addexcList(ps);
                }
                else
                {

                    m10.removeexcList(ps);
                }
            }
            else 
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 10am";

            if (checkBox8.Checked == false)
            {
                if (checkBox15.Checked == true)
                {
                    m10.addexcList(ps);
                }
                else
                {
                    m10.removeexcList(ps);
                }
            }
            else 
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 11am";

            if (checkBox7.Checked == false)
            {
                if (checkBox16.Checked == true)
                {
                    m10.addexcList(ps);
                }
                else
                {
                    m10.removeexcList(ps);
                }

            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 12pm";

            if (checkBox9.Checked == false)
            {
                if (checkBox14.Checked == true)
                {
                    m10.addexcList(ps);
                }
                else
                {
                    m10.removeexcList(ps);
                }

            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 1pm";

            if (checkBox10.Checked == false)
            {
                if (checkBox13.Checked == true)
                {
                    m10.addexcList(ps);
                }
                else
                {
                    m10.removeexcList(ps);
                }

            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            String ps = "Monday 2pm";

            if (checkBox11.Checked == false)
            {
                if (checkBox12.Checked == true)
                {
                    m10.addexcList(ps);
                }
                else
                {
                    m10.removeexcList(ps);
                }

            }
            else
            {
                mname1.Text = mName.Text;
                mReason.Text = "You cannot book this meeting with preference slots that are equal to exclusion slots. Try again";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem)
            {
                case "Computer": 
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add(cantor1.getLocName());
                        listBox2.Items.Add(cantor3.getLocName());
                        listBox2.Items.Add(cantor4.getLocName());
                        listBox2.Items.Add(cantor6.getLocName());
                        break;
                    }
                case "Projector":
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add(cantor1.getLocName());
                        listBox2.Items.Add(cantor3.getLocName());
                        listBox2.Items.Add(cantor4.getLocName());
                        listBox2.Items.Add(cantor5.getLocName());
                        listBox2.Items.Add(cantor6.getLocName());
                        break;
                    }
                case "Apple Mac":
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add(cantor2.getLocName());
                        listBox2.Items.Add(cantor4.getLocName());
                        listBox2.Items.Add(cantor5.getLocName());
                        listBox2.Items.Add(cantor6.getLocName());
                        break;
                    }
                case "Whiteboard":
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add(cantor2.getLocName());
                        listBox2.Items.Add(cantor4.getLocName());
                        listBox2.Items.Add(cantor5.getLocName());
                        listBox2.Items.Add(cantor6.getLocName());
                        break;
                    }
                case "Specialist Software PC's":
                    {
                        listBox2.Items.Clear();
                        listBox2.Items.Add(cantor3.getLocName());
                        listBox2.Items.Add(cantor5.getLocName());
                        listBox2.Items.Add(cantor6.getLocName());
                        break;
                    }
            }
        }

        public void conflict()
        {
            if (pa1.getImportance() == true || pa2.getImportance() == true && checkBox7.Checked == true)
            {
                saveBut.Enabled = false;
                mname1.Text = mName.Text;
                mReason.Text = "Important participants are unavailable at this time";
                sol1.Text = "Remove importance for relevent participants";
                sol2.Text = "Change preference slot";
                sol3.Text = "Change specific participants preference/exclusion slots";
                sol4.Text = "Cancel booked conflicting meeting";
                sol5.Text = "Replace unavaiable participant with another";
            }
            saveBut.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conflict();

            switch (listBox2.SelectedItem)
            {
                case "Cantor room 1":
                    {
                        m10.setLocation(cantor1);

                        break;
                    }

                case "Cantor room 2":
                    {
                        if (m10.getSlot() == "Monday 11am")
                        {
                            MessageBox.Show("Slot Monday 11am in Cantor Room 2 is taken", "Error!");
                            saveBut.Enabled = false;
                        }
                        else
                        { 
                            m10.setLocation(cantor2);
                        }
                        break;
                    }

                case "Cantor room 3":
                    {
                        if (m10.getSlot() == "Monday 12pm")
                        {
                            MessageBox.Show("Slot Monday 12pm in Cantor Room 3 is taken", "Error!");
                            saveBut.Enabled = false;
                        }
                        else
                        {
                            m10.setLocation(cantor3);
                        }
                        break;
                    }

                case "Cantor room 4":
                    {
                        m10.setLocation(cantor4);
                        break;
                    }

                case "Cantor room 5":
                    {
                        m10.setLocation(cantor5);
                        break;
                    }

                case "Cantor room 6":
                    {
                        if (m10.getSlot() == "Monday 1pm")
                        {
                            MessageBox.Show("Slot Monday 1pm in Cantor Room 6 is taken", "Error!");
                            saveBut.Enabled = false;
                        }
                        else 
                        {
                            m10.setLocation(cantor6);
                        }
                            break;
                    }

            }
        }

        private void solvBut1_Click(object sender, EventArgs e)
        {
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            mReason.Text = "";
            solvBut1.Enabled = false;
            saveBut.Enabled = true;
        }

        private void solveBut2_Click(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            checkBox6.Checked = true;
            mReason.Text = "";
            solveBut2.Enabled = false;
            saveBut.Enabled = true;

        }

        private void solveBut3_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            solveBut3.Enabled = false;
            checkBox27.Checked = true;
            checkBox30.Checked = true;
            checkBox29.Checked = true;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = listBox3.SelectedItem.ToString();
            button3.Enabled = true;
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                checkBox6.Checked = true;
                m10.setSlot("Monday 9am");

            }
            else { checkBox6.Checked = false; }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                checkBox8.Checked = true;
                m10.setSlot("Monday 10am");
            }
            else { checkBox8.Checked = false; }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                checkBox7.Checked = true;
                m10.setSlot("Monday 11am");
            }
            else { checkBox7.Checked = false; }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                checkBox9.Checked = true;
                m10.setSlot("Monday 12pm");
            }
            else { checkBox9.Checked = false; }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                checkBox10.Checked = true;
                m10.setSlot("Monday 1pm");
            }
            else { checkBox10.Checked = false; }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                checkBox11.Checked = true;
                m10.setSlot("Monday 2pm");
            }
            else { checkBox11.Checked = false; }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                checkBox17.Checked = true;
            }
            else { checkBox17.Checked = false; }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                checkBox15.Checked = true;
            }
            else { checkBox15.Checked = false; }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                checkBox16.Checked = true;
            }
            else { checkBox16.Checked = false; }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked == true)
            {
                checkBox14.Checked = true;
            }
            else { checkBox14.Checked = false; }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                checkBox13.Checked = true;
            }
            else { checkBox13.Checked = false; }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                checkBox12.Checked = true;
            }
            else { checkBox12.Checked = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveBut.Enabled = true;
            groupBox4.Visible = false;
        }

        private void solveBut4_Click(object sender, EventArgs e)
        {
            meetingList.RemoveAt(1);

            meetingsList.Items.Clear();
            foreach (Meeting m in meetingList)
            {
                meetingsList.Items.Add(m.getMeetingName() + "\t\t" + m.getSlot());
            }

            mReason.Text = "";
            solveBut4.Enabled = false;
            saveBut.Enabled = true;
        }

        private void solveBut5_Click(object sender, EventArgs e)
        {

        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            m10.setMeetingName(mName.Text);
            m10.setMeetingDesc(mDesc.Text);

            meetingList.Add(m10);
            meetingsList.Items.Clear();

            foreach (Meeting m in meetingList)
            {
                meetingsList.Items.Add(m.getMeetingName() + "\t\t" + m.getSlot());
            }

            groupBox3.Visible = false;
            groupBox2.Visible = false;
            clearForm();
        }

        public void clearForm()
        {
            mname1.Text = "";
            mReason.Text = "";
            mName.Text = "";
            mDesc.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox6.Checked = false;
            checkBox8.Checked = false;
            checkBox7.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox2.Items.Clear();
            listBox2.Items.Add(cantor1.getLocName());
            listBox2.Items.Add(cantor2.getLocName());
            listBox2.Items.Add(cantor3.getLocName());
            listBox2.Items.Add(cantor4.getLocName());
            listBox2.Items.Add(cantor5.getLocName());
            listBox2.Items.Add(cantor6.getLocName());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meetingList.RemoveAt(meetingsList.SelectedIndex);

            meetingsList.Items.Clear();
            foreach (Meeting m in meetingList)
            {
                meetingsList.Items.Add(m.getMeetingName() + "\t\t" + m.getSlot());
            }
        }
    }
}
