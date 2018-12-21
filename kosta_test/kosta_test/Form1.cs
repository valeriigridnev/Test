using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
       /* static private string connectionString = ConfigurationManager
            .ConnectionStrings[
                "kosta_test.Properties.Settings.TestDBConnectionStringkosta_test.Properties.Settings.TestDBConnectionString"]
            .ConnectionString;*/
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
            if (!string.IsNullOrEmpty(Имя.Text) && !string.IsNullOrWhiteSpace(Имя.Text) && !string.IsNullOrEmpty(Фамилия.Text) && !string.IsNullOrWhiteSpace(Фамилия.Text) &&
                !string.IsNullOrEmpty(Др.Text) && !string.IsNullOrWhiteSpace(Др.Text) && !string.IsNullOrEmpty(Серия.Text) && !string.IsNullOrWhiteSpace(Серия.Text) &&
                !string.IsNullOrEmpty(Номер.Text) && !string.IsNullOrWhiteSpace(Номер.Text) && !string.IsNullOrEmpty(Должность.Text) && !string.IsNullOrWhiteSpace(Должность.Text) &&
                !string.IsNullOrEmpty(Отдел.Text) && !string.IsNullOrWhiteSpace(Отдел.Text) && !string.IsNullOrEmpty(ID.Text) && !string.IsNullOrWhiteSpace(ID.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Empoyee] SET [FirstName] = @FirstName, [SurName]= @SurName, " +
                                                    "[Patronymic]=@Patronymic, [DateOfBirth]=@DateOfBirth," +
                                                    "[DocSeries]=@DocSeries, [DocNumber]=@DocNumber," +
                                                    "[Position]=@Position, [DepartmentID]=@DepartmentID " +
                                                    "where [ID] = @ID");
                command.Parameters.AddWithValue("FirstName", Имя.Text);
                command.Parameters.AddWithValue("SurName", Фамилия.Text);
                command.Parameters.AddWithValue("Patronymic", Отчество.Text);
                command.Parameters.AddWithValue("DateOfBirth", Др.Text);
                command.Parameters.AddWithValue("DocSeries", Серия.Text);
                command.Parameters.AddWithValue("DocNumber", Номер.Text);
                command.Parameters.AddWithValue("Position", Должность.Text);
                command.Parameters.AddWithValue("DepartmentID", Отдел.Text);
                command.Parameters.AddWithValue("ID", ID.Text);
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
                ID.Visible = true;
                label2.Visible = true;
                Имя.Visible = true;
                label3.Visible = true;
                Фамилия.Visible = true;
                label4.Visible = true;
                Отчество.Visible = true;
                label5.Visible = true;
                Др.Visible = true;
                label6.Visible = true;
                Серия.Visible = true;
                label7.Visible = true;
                Номер.Visible = true;
                label8.Visible = true;
                Должность.Visible = true;
                label9.Visible = true;
                Отдел.Visible = true;
                button2.Visible = true;

            }
        }
        #endregion

        #region Добавление нового сотрудника
        private void button3_Click(object sender, EventArgs e)
        {
            if (label11.Visible)
                label11.Visible = false;
            if (!string.IsNullOrEmpty(Имя.Text) && !string.IsNullOrWhiteSpace(Имя.Text) &&
                !string.IsNullOrEmpty(Фамилия.Text) && !string.IsNullOrWhiteSpace(Фамилия.Text) &&
                !string.IsNullOrEmpty(Др.Text) && !string.IsNullOrWhiteSpace(Др.Text) &&
                !string.IsNullOrEmpty(Серия.Text) && !string.IsNullOrWhiteSpace(Серия.Text) &&
                !string.IsNullOrEmpty(Номер.Text) && !string.IsNullOrWhiteSpace(Номер.Text) &&
                !string.IsNullOrEmpty(Должность.Text) && !string.IsNullOrWhiteSpace(Должность.Text) &&
                !string.IsNullOrEmpty(Отдел.Text) && !string.IsNullOrWhiteSpace(Отдел.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Empoyee] (FirstName, SureName, Patronymic, DateOfBirth, DocSeries, DocNumber, Position, DepartmentID)" +
                                                    "VALUES(@FirstName, @SureName, @Patronymic, @DateOfBirth, @DocSeries, @DocNumber, @Position, @DepartmentID)");

                command.Parameters.AddWithValue("FirstName", Имя.Text);
                command.Parameters.AddWithValue("SurName", Фамилия.Text);
                command.Parameters.AddWithValue("Patronymic", Отчество.Text);
                command.Parameters.AddWithValue("DateOfBirth", Др.Text);
                command.Parameters.AddWithValue("DocSeries", Серия.Text);
                command.Parameters.AddWithValue("DocNumber", Номер.Text);
                command.Parameters.AddWithValue("Position", Должность.Text);
                command.Parameters.AddWithValue("DepartmentID", Отдел.Text);

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
            ID.Visible = true;
            label2.Visible = true;
            Имя.Visible = true;
            label3.Visible = true;
            Фамилия.Visible = true;
            label4.Visible = true;
            Отчество.Visible = true;
            label5.Visible = true;
            Др.Visible = true;
            label6.Visible = true;
            Серия.Visible = true;
            label7.Visible = true;
            Номер.Visible = true;
            label8.Visible = true;
            Должность.Visible = true;
            label9.Visible = true;
            Отдел.Visible = true;
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
