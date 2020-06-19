using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace PatientAllergies
{
    public partial class FormPatientAllergies : Form
    {
        public FormPatientAllergies()
        {
            InitializeComponent();
            dateTimeDob.Format = DateTimePickerFormat.Custom;
            dateTimeDob.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnSearchPatient_Click(object sender, EventArgs e)
        {
            SearchPatients();
        }

        private void WorkingMessage()
        {
            lblErrorMessage.Text = "Working...";
            this.UseWaitCursor = true;
        }

        private void SearchAllergies(string PatientId)
        {
            WorkingMessage();
            listAllergies.Items.Clear();
            string FHIR_EndPoint = this.txtFHIREndpoint.Text.ToString();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);

            try
            {

                var p = new Hl7.Fhir.Rest.SearchParams();
                p.Add("patient", PatientId);

                var results = client.Search<AllergyIntolerance>(p);
                this.UseWaitCursor = false;
                lblErrorMessage.Text = "";
                while (results != null)
                {
                    if (results.Total == 0) lblErrorMessage.Text = "No allergies found";

                    foreach (var entry in results.Entry)
                    {

                        var Alrgy = (AllergyIntolerance)entry.Resource;
                        string Content = Alrgy.Code.Coding[0].Display
                            + " / " +Alrgy.VerificationStatus.Coding[0].Code
                            + " (" + Alrgy.ClinicalStatus.Coding[0].Code + ")";
                        listAllergies.Items.Add(Content);
                        

                    }
                    // get the next page of results
                    results = client.Continue(results);
                }
                }
            catch(Exception err)
            {
                lblErrorMessage.Text = "Error:" + err.Message.ToString();

            }
            if (lblErrorMessage.Text != "") { lblErrorMessage.Visible = true; }

        }
        private void SearchPatients()
        {
            WorkingMessage();
            listCandidates.Items.Clear();
            string FHIR_EndPoint = this.txtFHIREndpoint.Text.ToString();
            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);
            client.OnBeforeRequest += (object sender, BeforeRequestEventArgs e) =>
            {
                // Replace with a valid bearer token for the server
               // e.RawRequest.Headers.Add("Authorization", "Bearer ya29.QQIBibTwvKkE39hY8mdkT_mXZoRh7Ub9cK9hNsqrxem4QJ6sQa36VHfyuBe");
            };
            try
            {
                string patId = txtPatientID.Text.ToString();
                string patName = txtPatientName.Text.ToString();
                var p = new Hl7.Fhir.Rest.SearchParams();

                switch(SearchOption)
                {
                    case 1:
                        p.Add("_id", patId);
                        break;
                    case 2:
                        p.Add("name", patName);
                        break;
                    case 3:
                        p.Add("name", patName);
                        p.Add("birthdate", dateTimeDob.Text);
                        break;

                }

                var results = client.Search<Patient>(p);
                this.UseWaitCursor = false;
                lblErrorMessage.Text = "";

                while (results != null)
                {
                    if (results.Total == 0) lblErrorMessage.Text = "No patients found";
                    btnShowAllergies.Enabled = true;
                    foreach (var entry in results.Entry)
                    {

                        var Pat = (Patient)entry.Resource;
                        string Fam = "", Giv = "", ideS = "", ideV = "";
                        if (Pat.Name.Count > 0)
                        {
                             Fam = Pat.Name[0].Family;
                             Giv = Pat.Name[0].GivenElement[0].ToString();
                        }
                        if(Pat.Identifier.Count > 0)
                        {
                             ideS = Pat.Identifier[0]?.System;
                             ideV = Pat.Identifier[0]?.Value;
                        }
                        
                        string Content =  Fam+ " " + Giv+  " (" +ideS + "-" + ideV+")";
                        ListViewItem l = new ListViewItem
                        {
                            Text = Content,
                            Tag = entry.Resource.Id
                        };
                        listCandidates.Items.Add(l);
                        
                    }

                    // get the next page of results
                    results = client.Continue(results);
                }
            }
            catch (Exception err)
            {
                lblErrorMessage.Text = "Error:" + err.Message.ToString();
            }
            if (lblErrorMessage.Text != "") { lblErrorMessage.Visible = true; }

        }

        private void BtnShowAllergies_Click(object sender, EventArgs e)
        {
            ListViewItem l = (listCandidates.SelectedItem as ListViewItem);
            string patientId = l.Tag.ToString();
            SearchAllergies(patientId);
        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioPatientID_Click(object sender, EventArgs e)
        {
            SearchOption = 1;
            txtPatientID.Enabled = true;
            txtPatientName.Enabled = false;
            dateTimeDob.Enabled = false;
            btnSearchPatient.Enabled = true;
        }

        private void radioPatientName_Click(object sender, EventArgs e)
        {
            SearchOption = 2;
            txtPatientID.Enabled = false;
            txtPatientName.Enabled = true;
            dateTimeDob.Enabled = false;
            btnSearchPatient.Enabled = true;
        }

        private void radioPatNameDob_Click(object sender, EventArgs e)
        {
            SearchOption = 3;
            txtPatientID.Enabled = false;
            txtPatientName.Enabled = true;
            dateTimeDob.Enabled = true;
            btnSearchPatient.Enabled = true;
        }
    }
}
