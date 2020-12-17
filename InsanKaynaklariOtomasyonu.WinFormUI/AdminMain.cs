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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        AddAdmin add = new AddAdmin();
        ViewIslemKayit islem = new ViewIslemKayit();
        AddApptitudeTypes atypes = new AddApptitudeTypes();
        AddApptitudeQuestion aques = new AddApptitudeQuestion();
        AddPersonalityQuestion aper = new AddPersonalityQuestion();
        AddJob addjob = new AddJob();
        AddJobRequirement addjobreq = new AddJobRequirement();
        ViewPersonalityQuestion viperques = new ViewPersonalityQuestion();
        ViewApptitudeQuestion viappques = new ViewApptitudeQuestion();
        ViewJobDetails vijobdet = new ViewJobDetails();
        ViewApplicationForJobs viapfojob = new ViewApplicationForJobs();
        ViewMessagesRecords vimesrec = new ViewMessagesRecords();
        UpdateAdminPassword upadps = new UpdateAdminPassword();
       
        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add.IsDisposed)
                add = new AddAdmin();
            add.MdiParent = this;
            add.Show();
        }

        private void viewIsLemKayitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (islem.IsDisposed)
                islem = new ViewIslemKayit();

            islem.MdiParent = this;
            islem.Show();

        }

        private void addApptitudeTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (atypes.IsDisposed)
                atypes = new AddApptitudeTypes();
            atypes.MdiParent = this;
            atypes.Show();
        }

        private void addApptitudeQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aques.IsDisposed)
                aques = new AddApptitudeQuestion();
            aques.MdiParent = this;
            aques.Show();
        }

        private void addPersonalityQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aper.IsDisposed)
                aper = new AddPersonalityQuestion();
            aper.MdiParent = this;
            aper.Show();
        }

        private void addJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addjob.IsDisposed)
                addjob = new AddJob();
            addjob.MdiParent = this;
            addjob.Show();
        }

        private void jobRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addjobreq.IsDisposed)
                addjobreq = new AddJobRequirement();
            addjobreq.MdiParent = this;
            addjobreq.Show();
        }

        private void viewPersonalityQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viperques.IsDisposed)
                viperques = new ViewPersonalityQuestion();
            viperques.MdiParent = this;
            viperques.Show();
        }

        private void viewApptitudeQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viappques.IsDisposed)
                viappques = new ViewApptitudeQuestion();
            viappques.MdiParent = this;
            viappques.Show();
        }

        private void viewJobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vijobdet.IsDisposed)
                vijobdet = new ViewJobDetails();
            vijobdet.MdiParent = this;
            vijobdet.Show();
        }


        private void viewApplicationForJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viapfojob.IsDisposed)
                viapfojob = new ViewApplicationForJobs();
            viapfojob.MdiParent = this;
            viapfojob.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin adm = new AdminLogin();
            adm.Show();
            this.Close();
        }

        private void viewMessagesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vimesrec.IsDisposed)
                vimesrec = new ViewMessagesRecords();
            vimesrec.MdiParent = this;
            vimesrec.Show();
        }

        private void updateYourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upadps.IsDisposed)
                upadps = new UpdateAdminPassword();
            upadps.MdiParent = this;
            upadps.Show();
        }
    }
}
