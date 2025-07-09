using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace DotNetLab
{
    class CRUD
    {
        public string ConnectionString = "SERVER=localhost;DATABASE=dotnetCRUD;UID=root;PASSWORD=;";
        MySqlConnection connect;

        public void Connection()
        {
            connect = new MySqlConnection(ConnectionString);
            try
            {
                connect.Open();
                Console.WriteLine("Connection Successful.\n");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student roll number: ");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter student semester: ");
                int semester = int.Parse(Console.ReadLine());

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO students (name, rollno, semester) VALUES (@name, @rollno, @semester)",
                    connect))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@rollno", roll);
                    cmd.Parameters.AddWithValue("@semester", semester);

                    int num = cmd.ExecuteNonQuery();
                    Console.WriteLine(num == 1
                        ? "\nStudent added successfully.\n"
                        : "\nStudent addition failed.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void SelectStudents()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", connect))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Console.WriteLine("\n===== Student Records =====");
                        Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-10}", "ID", "Name", "Roll No", "Semester");
                        Console.WriteLine(new string('-', 50));

                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-10}",
                                row["id"], row["name"], row["rollno"], row["semester"]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No students found in the database.\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void DeleteStudent()
        {
            try
            {
                Console.Write("Enter student ID to delete: ");
                int id = Convert.ToInt32(Console.ReadLine());

                using (MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM students WHERE id=@sid", connect))
                {
                    cmd.Parameters.AddWithValue("@sid", id);
                    int num = cmd.ExecuteNonQuery();
                    Console.WriteLine(num == 1
                        ? "\nStudent deleted successfully.\n"
                        : "\nStudent delete failed (ID might not exist).\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void UpdateStudent()
        {
            try
            {
                Console.Write("Enter student ID to update: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new details:");
                Console.Write("New name: ");
                string name = Console.ReadLine();
                Console.Write("New roll number: ");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("New semester: ");
                int semester = int.Parse(Console.ReadLine());

                using (MySqlCommand cmd = new MySqlCommand(
                    "UPDATE students SET name = @name, semester = @semester, rollno = @rollno WHERE id = @sid",
                    connect))
                {
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@rollno", roll);

                    int num = cmd.ExecuteNonQuery();
                    if (num == 1)
                    {
                        Console.WriteLine("\nStudent updated successfully.");
                        ShowStudentById(id);
                    }
                    else
                    {
                        Console.WriteLine("\nStudent update failed (ID might not exist).\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void ShowStudentById(int id)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE id = @id", connect))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("\n----- Updated Record -----");
                        Console.WriteLine("ID       : " + reader["id"]);
                        Console.WriteLine("Name     : " + reader["name"]);
                        Console.WriteLine("Roll No  : " + reader["rollno"]);
                        Console.WriteLine("Semester : " + reader["semester"]);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Record not found.\n");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            CRUD crud = new CRUD();
            crud.Connection();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("========= STUDENT CRUD MENU =========");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        crud.AddStudent();
                        break;
                    case "2":
                        crud.SelectStudents();
                        break;
                    case "3":
                        crud.UpdateStudent();
                        break;
                    case "4":
                        crud.DeleteStudent();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the application. Goodbye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-5.\n");
                        break;
                }
            }
        }
    }
}
