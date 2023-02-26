using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileRenamer;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = txtDirectory.Text;
            try
            {
                //Validate the new string
                string newText;
                if (FileRenamer.ValidateNewString(txtNewText.Text))
                {
                    newText = txtNewText.Text;
                }
                else
                {
                    throw new InvalidOperationException("Files names cannot contain the following characters:\n/ \\ * : ? \" < > |");
                }
               
                //Gather the files in the directory
                DirectoryInfo di = new DirectoryInfo(@txtDirectory.Text);
                FileInfo[] files = di.GetFiles();
               
                //Set the integer for the first and last files to be renamed
                Tuple<int, int> range = FileRenamer.SetRangeOfFilesToRename(txtFileStart.Text, txtFileEnd.Text, files.Length);
                if (range.Item1 == -1)
                {
                    txtFileStart.BackColor = Color.Red;
                    throw new InvalidOperationException("First file to rename cannot be greater than last file to rename");
                }

                //Set number of characters to replace AND starting position for inserting the new text (except if 'end')
                int numOfCharsToReplace = 0;
                int startingPosition = 0;
                if (btnRadioCustomize.Checked)
                {
                    numOfCharsToReplace = (txtLength.Text != "") ? Int32.Parse(txtLength.Text) : 0;
                    startingPosition = FileRenamer.SetStartPosition(txtStart.Text);
                }

                string[,] nameList = new string[2,range.Item2 - range.Item1];
            
                if (chkAddIncrement.Checked)
                {
                    ushort incrementLength = (txtIncrementLength.Text != "" && UInt16.Parse(txtIncrementLength.Text) >= (ushort)1) ? UInt16.Parse(txtIncrementLength.Text) : (ushort)0;
                    bool incrementLengthValid = (incrementLength != 0);
                    ushort incrementStart = (txtIncrementStart.Text != "" && UInt16.Parse(txtIncrementStart.Text) >= (ushort)1) ? UInt16.Parse(txtIncrementStart.Text) : (ushort)1;
                    byte incrementStep = (txtIncrementSteps.Text != "") ? Byte.Parse(txtIncrementSteps.Text) : (byte)1;
                    if (btnRadioCustomize.Checked)
                    {
                        nameList = FileRenamer.RenameFilesWithIncrement(newText, range, files, startingPosition, numOfCharsToReplace, incrementLength, incrementLengthValid,
                            incrementStart, incrementStep);
                    } 
                    else if (btnRadioStart.Checked)
                    {
                        nameList = FileRenamer.RenameFilesAtStartWithIncrement(newText, range, files, incrementLength, incrementLengthValid,
                            incrementStart, incrementStep);
                    }
                    else
                    {
                        nameList = FileRenamer.RenameFilesAtEndWithIncrement(newText,range,files,incrementLength,incrementLengthValid,
                            incrementStart, incrementStep);
                    }
                }
                else
                {
                    if (btnRadioCustomize.Checked)
                    {
                        nameList = FileRenamer.RenameFiles(newText, range, files, startingPosition, numOfCharsToReplace);
                    }
                    else if (btnRadioStart.Checked)
                    {
                        nameList = FileRenamer.RenameFilesAtStart(newText, range, files);
                    } 
                    else
                    {
                        nameList = FileRenamer.RenameFilesAtEnd(newText, range, files);
                    } 
                }
                FileRenamer.WriteBackupforRenamedFiles(di.FullName,nameList);
                btnUndoRename.Enabled = true;
                btnUndoRename.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtNewText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void chkAddIncrement_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAddIncrement.Checked)
            {

                txtIncrementStart.BackColor = Color.FromArgb(157,157,157);
                txtIncrementLength.BackColor = Color.FromArgb(157, 157, 157);
                txtIncrementSteps.BackColor = Color.FromArgb(157, 157, 157);
               
                txtIncrementStart.Enabled = false;
                txtIncrementLength.Enabled = false;
                txtIncrementSteps.Enabled = false; 
            }
            else
            {
                txtIncrementStart.BackColor = Color.FromArgb(71, 71, 71);
                txtIncrementLength.BackColor = Color.FromArgb(71, 71, 71);
                txtIncrementSteps.BackColor = Color.FromArgb(71, 71, 71);
                
                txtIncrementStart.Enabled = true;
                txtIncrementLength.Enabled = true;
                txtIncrementSteps.Enabled=true;
            }
        }

        private void btnSearchDuplicates_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo diOne = new DirectoryInfo(@txtSearchDirOne.Text);
                FileInfo[] filesOne = diOne.GetFiles();

                DirectoryInfo diTwo = new DirectoryInfo(@txtSearchDirTwo.Text);
                FileInfo[] filesTwo = diTwo.GetFiles();

                string output = "";
                ushort count = 0;
                bool match = false;
                int j = 0;
                double sizeOfFile;
                string txtSizeOfFile = "";

                if (filesOne.Length > 0 && filesTwo.Length > 0)
                {
                    for (int i = 0; i < filesOne.Length; i++) {
                        do
                        {
                            if (filesOne[i].Name == filesTwo[j].Name)
                            {
                                match = true;
                                count++;
                                if (filesOne[i].Length > Math.Pow(10,3))
                                {
                                    if (filesOne[i].Length > Math.Pow(10, 6))
                                    {
                                        if (filesOne[i].Length > Math.Pow(10, 9))
                                        {
                                            sizeOfFile = (filesOne[i].Length / Math.Pow(10, 9));
                                            txtSizeOfFile = sizeOfFile.ToString("#.##") + " GB";
                                        }
                                        else
                                        {
                                            sizeOfFile = (filesOne[i].Length / Math.Pow(10, 6));
                                            txtSizeOfFile = sizeOfFile.ToString("#.##") + " MB";
                                        }
                                    } 
                                    else
                                    {
                                        sizeOfFile = (filesOne[i].Length / Math.Pow(10, 3));
                                        txtSizeOfFile = sizeOfFile.ToString("#.##") + " KB";
                                    }                                   
                                }
                                else
                                {
                                    sizeOfFile = filesOne[i].Length;
                                    txtSizeOfFile = sizeOfFile.ToString("#.##") + " Bytes";
                                }
                                output += "\n" + count + ") " + filesOne[i].Name + " (" + txtSizeOfFile + ") [File #" + (i + 1) + "]";
                            }
                            j++;
                        } while (!match && j < filesTwo.Length);
                        j = 0;
                        match = false;
                    }
                    if (output.Length > 0)
                    {
                        MessageBox.Show("Duplicates:" + output, "Confirm", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No Duplicates Found", "Confirm", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new InvalidOperationException("Directories must have at least one file");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRadioCustomize.Checked)
            {
                txtStart.BackColor = Color.FromArgb(71, 71, 71);
                txtStart.Enabled = true;
                txtLength.BackColor = Color.FromArgb(71,71,71);
                txtLength.Enabled = true;
            }
            else
            {
                txtStart.BackColor = Color.FromArgb(157, 157, 157);
                txtStart.Enabled = false;
                txtLength.BackColor = Color.FromArgb(157, 157, 157);
                txtLength.Enabled = false;
            }
        }

        private void btnUndoRename_Click(object sender, EventArgs e)
        {
            string fileName = "renamedBackup.json";
            try
            {
                string json = File.ReadAllText(fileName);
                var options = new JsonSerializerOptions();
                RenamedFiles files = JsonSerializer.Deserialize<RenamedFiles>(json);
                FileRenamer.UndoRenamedFiles(files);

                btnUndoRename.Enabled = false;
                btnUndoRename.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
