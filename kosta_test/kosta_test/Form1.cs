using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosta_test
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\1\source\repos\GitHub\Test\kosta_test\kosta_test\TestDB.mdf; Integrated Security = True";

        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public Form1()
        {
            
            InitializeComponent();
        }

         private async void Form1_Load(object sender, EventArgs e)
         {
             treeView1.Nodes.Clear();;
             await sqlConnection.OpenAsync();
             
             


         }


        #region Вывод списков отделов
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Dep";
            param.Value = e.Node.Text.ToString();
            SqlCommand command = new SqlCommand("Select * from [Empoyee] join [Department] on Empoyee.DepartmentID = Department.ID where Department.Name = @Dep ", sqlConnection);
            command.Parameters.Add(param);
            sqlReader = command.ExecuteReader();
            textBox1.Text = "Список сотрудников: " + e.Node.Text;
            while (sqlReader.Read())
            {
                listBox1.Items.Add(Convert.ToString(sqlReader["ID"]) + "  " + Convert.ToString(sqlReader["FirstName"]) +
                                   "  " + Convert.ToString(sqlReader["SurName"]) +
                                   "  " + Convert.ToString(sqlReader["Patronymic"]) + "  " +
                                   Convert.ToString(sqlReader["DateOfBirth"]) + "  " +
                                   Convert.ToString(sqlReader["DocSeries"]) + "  " +
                                   Convert.ToString(sqlReader["DocNumber"]) + "  " +
                                   Convert.ToString(sqlReader["Position"]) + "  " +
                                   Convert.ToString(sqlReader["DepartmentID"]));
            }

            if (sqlReader != null)
            {
                sqlReader.Close();
            }
        }
        #endregion

        #region Прорисовка дерева

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;


            SqlCommand command =
                new SqlCommand("Select * from [Department] order by [ParentDepartmentID]", sqlConnection);


            try
            {
                sqlReader = command.ExecuteReader();

                var nodes = new Dictionary<Guid, TreeNode>();

                while (sqlReader.Read())
                {
                    Guid id = sqlReader.GetGuid(0);
                    string name = sqlReader.GetString(1);
                    SqlGuid? parentId = sqlReader.IsDBNull(3) ? null : (SqlGuid?) sqlReader.GetSqlGuid(3);
                    string code = sqlReader.GetString(2);

                    TreeNode node = new TreeNode(name);
                    TreeNode parent;
                    if (parentId.Equals(null))
                    {
                        treeView1.Nodes.Add(node);
                    }
                    else if (nodes.TryGetValue(parentId.Value.Value, out parent))
                    {
                        parent.Nodes.Add(node);
                    }

                    nodes.Add(id, node);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        #endregion
            
        #region Обновление информации о сотруднике
        private void button2_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
                label11.Visible = false;
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Empoyee] SET [FirstName] = @FirstName, [SurName]= @SurName, " +
                                                    "[Patronymic]=@Patronymic, [DateOfBirth]=@DateOfBirth," +
                                                    "[DocSeries]=@DocSeries, [DocNumber]=@DocNumber," +
                                                    "[Position]=@Position, [DepartmentID]=@DepartmentID " +
                                                    "where [ID] = @ID");
                command.Parameters.AddWithValue("FirstName", textBox2.Text);
                command.Parameters.AddWithValue("SurName", textBox3.Text);
                command.Parameters.AddWithValue("Patronymic", textBox4.Text);
                command.Parameters.AddWithValue("DateOfBirth", textBox5.Text);
                command.Parameters.AddWithValue("DocSeries", textBox6.Text);
                command.Parameters.AddWithValue("DocNumber", textBox7.Text);
                command.Parameters.AddWithValue("Position", textBox8.Text);
                command.Parameters.AddWithValue("DepartmentID", textBox9.Text);
                command.Parameters.AddWithValue("ID", textBox10.Text);
            }
            else
            {
              
                label11.Text = "Не все обязательные поля заполнены!";
                label11.Visible = true;
            }


        }
        #endregion

        #region Появление кнопок для редактирования
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                label1.Visible = true;
                textBox10.Visible = true;
                label2.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;
                label7.Visible = true;
                textBox7.Visible = true;
                label8.Visible = true;
                textBox8.Visible = true;
                label9.Visible = true;
                textBox9.Visible = true;
                button2.Visible = true;

            }
        }
        #endregion

        #region Добавление нового сотрудника
        private void button3_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
                label11.Visible = false;
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Empoyee] (FirstName, SureName, Patronymic, DateOfBirth, DocSeries, DocNumber, Position, DepartmentID)" +
                                                    "VALUES(@FirstName, @SureName, @Patronymic, @DateOfBirth, @DocSeries, @DocNumber, @Position, @DepartmentID)");

                command.Parameters.AddWithValue("FirstName", textBox2.Text);
                command.Parameters.AddWithValue("SurName", textBox3.Text);
                command.Parameters.AddWithValue("Patronymic", textBox4.Text);
                command.Parameters.AddWithValue("DateOfBirth", textBox5.Text);
                command.Parameters.AddWithValue("DocSeries", textBox6.Text);
                command.Parameters.AddWithValue("DocNumber", textBox7.Text);
                command.Parameters.AddWithValue("Position", textBox8.Text);
                command.Parameters.AddWithValue("DepartmentID", textBox9.Text);

            }
            else
            {
                label11.Visible = true;
                label11.Text = "Не все обязательные поля заполнены!";
            }
        }
        #endregion


        #region Появление кнопок для добавления сотрудника
        private void label10_Click(object sender, EventArgs e)

        {

            label1.Visible = true;
            textBox10.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
            label7.Visible = true;
            textBox7.Visible = true;
            label8.Visible = true;
            textBox8.Visible = true;
            label9.Visible = true;
            textBox9.Visible = true;
            button3.Visible = true;


        }
        #endregion


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
