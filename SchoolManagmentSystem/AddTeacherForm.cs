using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagmentSystem.LoginForm;
using System.IO;
using System.Globalization;

namespace SchoolManagmentSystem
{
    public partial class AddTeacherForm : UserControl
    {

        public AddTeacherForm()
        {
            InitializeComponent();
            TeacherDisplayData();
            ClearFields();
        }
        public void TeacherDisplayData()
        {
            AddTeachersData addTD = new AddTeachersData();
            teachersGridView.DataSource = addTD.TeacherData();
        }

        private void teacherAddBtn_Click(object sender, EventArgs e)
        {
            if (teacherName.Text == "" || teacherID.Text == "" || teacherGender.SelectedItem == null ||
                teacherAddress.Text == "" || teacherStatus.SelectedItem == null ||
                teacherImage.Image == null || imagePath == null)
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //Check if teacher ID already exists
                        string checkTeacherId = "SELECT COUNT(*) FROM teachers WHERE teacher_id=@teacherID";
                        using (SqlCommand checkTID = new SqlCommand(checkTeacherId, connect))
                        {
                            checkTID.Parameters.AddWithValue("@teacherID", teacherID.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show($"Teacher ID: {teacherID.Text.Trim()} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                                string insertData = "INSERT INTO teachers " +
                                                           "(teacher_id, teacher_name, teacher_gender, teacher_address, teacher_image, teacher_status, date_insert)" +
                                                           "VALUES(@teacherID, @teacherName, @teacherGender, @teacherAddress, @teacherImage, @teacherStatus, @dateInsert)";

                                //To save to your directory
                                string path = Path.Combine(@"C:\Users\lyubo\Desktop\engineering\programming\C#\School Managment System\SchoolManagmentSystem\SchoolManagmentSystem\Teacher_Directory\", teacherID.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(imagePath, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacherID.Text);
                                    cmd.Parameters.AddWithValue("@teacherName", teacherName.Text);
                                    cmd.Parameters.AddWithValue("@teacherGender", teacherGender.Text);
                                    cmd.Parameters.AddWithValue("@teacherAddress", teacherAddress.Text);
                                    cmd.Parameters.AddWithValue("@teacherImage", path);
                                    cmd.Parameters.AddWithValue("@teacherStatus", teacherStatus.Text);
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();
                                    TeacherDisplayData();
                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();
                                }

                            }

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
        }

        public void ClearFields()
        {
            teacherID.Text = string.Empty;
            teacherName.Text = string.Empty;
            teacherGender.SelectedIndex = -1;
            teacherAddress.Text = string.Empty;
            teacherStatus.SelectedIndex = -1;
            teacherImage.ImageLocation = null;
        }
        private String imagePath;
        private void teacherImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageFile = new OpenFileDialog();
            openImageFile.Filter = "Image files (*.jpg; *.png )|*.jpg;*.png";
            if (openImageFile.ShowDialog() == DialogResult.OK)
            {
                imagePath = openImageFile.FileName;
                teacherImage.ImageLocation = imagePath;
            }

        }

        private void teacherClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void teacherUpdateBtn_Click(object sender, EventArgs e)
        {
            if (teacherName.Text == "" || teacherID.Text == "" || teacherGender.SelectedItem == null ||
                teacherAddress.Text == "" || teacherStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select item first!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        DialogResult check = MessageBox.Show($"Are you sure you want to Update Teacher ID: {teacherID.Text.Trim()} ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            String updateData = "UPDATE teachers SET teacher_name=@teacherName, teacher_gender=@teacherGender, " +
                                "teacher_address=@teacherAddress, teacher_status=@teacherStatus," +
                                "date_update=@dateUpdate WHERE teacher_id=@teacherID";

                            ////To save to your directory
                            //string path = Path.Combine(@"C:\Users\lyubo\Desktop\engineering\programming\C#\School Managment System\SchoolManagmentSystem\SchoolManagmentSystem\Teacher_Directory\", teacherID.Text.Trim() + ".jpg");
                            //string directoryPath = Path.GetDirectoryName(path);

                            //if (!Directory.Exists(directoryPath))
                            //{
                            //    Directory.CreateDirectory(directoryPath);
                            //}
                            //File.Copy(imagePath, path, true);

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                DateTime today = DateTime.Today;
                                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                                cmd.Parameters.AddWithValue("@teacherName", teacherName.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherGender", teacherGender.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherAddress", teacherAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherStatus", teacherStatus.Text.Trim());
                                //cmd.Parameters.AddWithValue("@teacherImage", path);
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());
                                cmd.Parameters.AddWithValue("@teacherID", teacherID.Text.Trim());

                                cmd.ExecuteNonQuery();
                                connect.Close();
                                TeacherDisplayData();
                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void teachersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teachersGridView.Rows[e.RowIndex];
                teacherID.Text = row.Cells[1].Value.ToString();
                teacherName.Text = row.Cells[2].Value.ToString();
                teacherGender.Text = row.Cells[3].Value.ToString();
                teacherAddress.Text = row.Cells[4].Value.ToString();
                string imageData = row.Cells[5].Value.ToString();
                if (imageData.Length > 0 && imageData != null)
                {

                    teacherImage.Image = Image.FromFile(imageData);

                }
                else
                {
                    teacherImage.Image = null;
                }
                teacherStatus.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
