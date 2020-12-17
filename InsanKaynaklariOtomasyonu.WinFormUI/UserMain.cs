using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }
    
        ChangePersonalInformation chaperinf = new ChangePersonalInformation();
        ChangeApptitudeInformation chaptidi = new ChangeApptitudeInformation();
        ViewApplicableJobs viappjb = new ViewApplicableJobs();
        TakeAnExam takex = new TakeAnExam();
        ViewMyApplication vimyapp = new ViewMyApplication();
        MyMessages mymsg = new MyMessages();
        private void changePersonalInfromationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (chaperinf.IsDisposed)
                chaperinf = new ChangePersonalInformation();
            chaperinf.MdiParent = this;
            chaperinf.Show();
        }

        private void changeApptitudeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chaptidi.IsDisposed)
                chaptidi = new ChangeApptitudeInformation();
            chaptidi.MdiParent = this;
            chaptidi.Show();
        }
        private void takeAnExamForASkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (takex.IsDisposed)
                takex = new TakeAnExam();
            takex.MdiParent = this;
            takex.Show();
           
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLogin lgn = new UserLogin();
            lgn.Show();
            this.Close();
        }

        private void viewApplicableJobsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (viappjb.IsDisposed)
                viappjb = new ViewApplicableJobs();
            viappjb.MdiParent = this;
            viappjb.Show();
        }
        private void myApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vimyapp.IsDisposed)
                vimyapp = new ViewMyApplication();
            vimyapp.MdiParent = this;
            vimyapp.Show();
        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mymsg.IsDisposed)
                mymsg = new MyMessages();
            mymsg.MdiParent = this;
            mymsg.Show();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {

        }
    }
}
