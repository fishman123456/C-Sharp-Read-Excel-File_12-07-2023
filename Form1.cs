namespace C_Sharp_Read_Excel_File_12_07_2023
{
    public partial class Form1 : Form
    {
        New_Files_Excel new_Files_Excel = new New_Files_Excel();
        public Form1()
        {
            InitializeComponent();

        }

        private void Butt_CreateNewFiles_Click(object sender, EventArgs e)
        {
            New_Files_Excel.NewFiles();
        }

        private void Butt_LoadFiles_Click(object sender, EventArgs e)
        {
            New_Files_Excel.LoadFiles();
            
            listBox1.Items.Add();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}