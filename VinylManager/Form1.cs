using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VinylManager
{
	public class Form1 : Form
	{
		private static string string_0;

		private static string string_1;

		private string string_2;

		private string string_3;

		private IntPtr intptr_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int[] int_6;

		private string[] string_4;

		private string string_5;

		private string string_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private int int_10;

		private int int_11;

		private int int_12;

		private int int_13;

		private int int_14;

		private int int_15;

		private bool bool_0;

		private bool bool_1;

		private bool bool_2;

		private bool bool_3;

		private bool bool_4;

		private bool bool_5;

		private bool bool_6;

		private bool bool_7;

		private bool bool_8;

		private bool bool_9;

		private int int_16;

		private int int_17;

		private int int_18;

		private int int_19;

		private int int_20;

		private int int_21;

		private int int_22;

		private int int_23;

		private int int_24;

		private int int_25;

		private int int_26;

		private int int_27;

		private int int_28;

		private int int_29;

		private int int_30;

		private int int_31;

		private int int_32;

		private int int_33;

		private int int_34;

		private int int_35;

		private int int_36;

		private int int_37;

		private int int_38;

		private int int_39;

		private int int_40;

		private int int_41;

		private int int_42;

		private int int_43;

		private int int_44;

		private int int_45;

		private int int_46;

		private int int_47;

		private int int_48;

		private int int_49;

		private int int_50;

		private int int_51;

		private int int_52;

		private int[] int_53;

		private int[] int_54;

		private double[,] double_0;

		private double[,] double_1;

		private int[] int_55;

		private int[] int_56;

		private int int_57;

		private int int_58;

		private double double_2;

		private double double_3;

		private int int_59;

		private int int_60;

		private int int_61;

		private byte[,] byte_0;

		private int int_62;

		private byte byte_1;

		private byte byte_2;

		private bool bool_10;

		private bool bool_11;

		private Thread thread_0;

		private Class1 class1_0;

		private Class6 class6_0;

		private Class4 gMtZudvhFe;

		private int int_63;

		private int int_64;

		private int int_65;

		private bool bool_12;

		private bool bool_13;

		private List<VinylsListFromServer> list_0;

		private int int_66;

		private string string_7;

		private Form1.Delegate0 delegate0_0;

		private Form1.Delegate1 delegate1_0;

		private Form1.Delegate2 delegate2_0;

		private Form1.Delegate3 delegate3_0;

		private Form1.Delegate4 delegate4_0;

		private Form1.Delegate5 delegate5_0;

		private Form1.Delegate6 delegate6_0;

		private Form1.Delegate7 delegate7_0;

		private static string string_8;

		private static string string_9;

		private IContainer icontainer_0;

		private NumericUpDown layerPanel1;

		private GroupBox groupBox1;

		private NumericUpDown layerPanel1Y;

		private Label label2;

		private NumericUpDown layerPanel1X;

		private GroupBox groupBox2;

		private Label label1;

		private GroupBox groupBox3;

		private Label DyxZieVhnS;

		private Label label3;

		private NumericUpDown layerPanel1c4y;

		private NumericUpDown layerPanel1c4x;

		private NumericUpDown layerPanel1c4h;

		private NumericUpDown layerPanel1c3y;

		private NumericUpDown layerPanel1c3x;

		private NumericUpDown layerPanel1c3h;

		private NumericUpDown layerPanel1c2y;

		private NumericUpDown layerPanel1c2x;

		private NumericUpDown layerPanel1c2h;

		private NumericUpDown layerPanel1c1y;

		private NumericUpDown layerPanel1c1x;

		private NumericUpDown layerPanel1c1h;

		private NumericUpDown layerPanel1s;

		private NumericUpDown layerPanel1r;

		private NumericUpDown layerPanel1sY;

		private NumericUpDown layerPanel1sX;

		private NumericUpDown layerPanel3c4y;

		private NumericUpDown layerPanel3;

		private NumericUpDown layerPanel3c4x;

		private NumericUpDown layerPanel3X;

		private NumericUpDown layerPanel3c4h;

		private NumericUpDown layerPanel3Y;

		private NumericUpDown layerPanel3c3y;

		private NumericUpDown layerPanel3sX;

		private NumericUpDown BdsEcsiibb;

		private NumericUpDown layerPanel3sY;

		private NumericUpDown layerPanel3c3h;

		private NumericUpDown layerPanel3r;

		private NumericUpDown layerPanel3c2y;

		private NumericUpDown layerPanel3s;

		private NumericUpDown layerPanel3c2x;

		private NumericUpDown layerPanel3c1h;

		private NumericUpDown layerPanel3c2h;

		private NumericUpDown layerPanel3c1x;

		private NumericUpDown layerPanel3c1y;

		private NumericUpDown layerPanel2c4y;

		private NumericUpDown layerPanel2;

		private NumericUpDown layerPanel2c4x;

		private NumericUpDown layerPanel2X;

		private NumericUpDown layerPanel2c4h;

		private NumericUpDown layerPanel2Y;

		private NumericUpDown layerPanel2c3y;

		private NumericUpDown layerPanel2sX;

		private NumericUpDown layerPanel2c3x;

		private NumericUpDown layerPanel2sY;

		private NumericUpDown layerPanel2c3h;

		private NumericUpDown layerPanel2r;

		private NumericUpDown layerPanel2c2y;

		private NumericUpDown layerPanel2s;

		private NumericUpDown layerPanel2c2x;

		private NumericUpDown layerPanel2c1h;

		private NumericUpDown layerPanel2c2h;

		private NumericUpDown layerPanel2c1x;

		private NumericUpDown layerPanel2c1y;

		private Button button6;

		private Button button1;

		private ListBox listBox1;

		private Button button2;

		private Label label11;

		private Label label10;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private TextBox inputR;

		private TextBox inputSX;

		private TextBox inputY;

		private TextBox inputX;

		private Button butRminus;

		private Button butRplus;

		private Button button_0;

		private Button button_1;

		private Button button_2;

		private Button button_3;

		private Button butYminus;

		private Button butYplus;

		private Button butXminus;

		private Button butXplus;

		private Label label14;

		private Label label13;

		private Button colorFilterLive;

		private Button colorFilterButton;

		private Label label16;

		private Label label15;

		private NumericUpDown colorSetToy;

		private NumericUpDown colorSetTox;

		private NumericUpDown colorSetToh;

		private NumericUpDown colorFiltery;

		private NumericUpDown colorFilterx;

		private NumericUpDown colorFilterh;

		private Button deleteButton;

		private Button uploadButton;

		private Label label24;

		private TextBox OeMxuosSgo;

		private Label label23;

		private Label label22;

		private NumericUpDown SaveToLayer;

		private NumericUpDown SaveFromLayer;

		private Label label21;

		private Label label20;

		private Label LoadToLayer;

		private NumericUpDown LoadFromLayer;

		private Label label18;

		private Button saveButton;

		private Button loadButton;

		private Button refreshAuto;

		private Button MirrorButton;

		private Label label17;

		private NumericUpDown layerToMirror;

		private GroupBox groupBox4;

		private Label label27;

		private TextBox saveAuthor;

		private Label label25;

		private Button button27;

		private Button button5;

		private Label label12;

		private Label label26;

		private Label lLayersA;

		private Label lLayersC;

		private Button butReCenter;

		private Label playerNameLabel;

		private Button refreshFolder;

		private Button button3;

		private Label label28;

		private TextBox saveDesc;

		private Label label29;

		private Label loadDesc;

		private Label label32;

		private Label loadAuthor;

		private Label dqmheTawJe;

		private Button button4;

		private TextBox inputSY;

		private Button button_steal;

		private RichTextBox logger;

		static Form1()
		{
			Class9.gVVuj4FzFXpvb();
			Form1.string_0 = "NEED FOR SPEED™ WORLD";
			Form1.string_1 = "nfsw";
			Form1.string_8 = "VinylHack";
			Form1.string_9 = "v6";
		}

		public Form1()
		{
			Class9.gVVuj4FzFXpvb();
			this.string_2 = "";
			this.string_3 = "";
			this.string_5 = "";
			this.string_6 = "";
			this.bool_2 = true;
			this.int_53 = new int[32];
			this.int_54 = new int[32];
			this.double_0 = new double[32, 2];
			this.double_1 = new double[32, 2];
			this.int_55 = new int[32];
			this.int_56 = new int[32];
			this.int_60 = 100;
			this.int_61 = 100;
			this.byte_0 = new byte[32, 4];
			this.int_62 = -1;
			this.bool_11 = true;
			this.class1_0 = new Class1(Form1.string_0, Form1.string_1);
			this.bool_13 = true;
			this.list_0 = new List<VinylsListFromServer>();
			this.int_66 = 31;
			base();
			this.int_1 = 9506668;
			this.int_2 = 8972152;
			this.int_10 = 44484;
			this.int_9 = 2932;
			this.int_5 = 9038112;
			this.int_3 = 9359208;
			this.int_4 = 9359164;
			this.int_6 = new int[] { 2578 };
			char[] chrArray = new char[] { ',' };
			this.string_4 = "berkay,berkay2578,EHEHEH,IAM,JUST,JOKING".Split(chrArray, StringSplitOptions.None);
			this.InitializeComponent();
		}

		private void butReCenter_Click(object sender, EventArgs e)
		{
			this.int_16 = 0;
		}

		private void butRminus_Click(object sender, EventArgs e)
		{
			int num = -1 * Convert.ToInt32(this.inputR.Text);
			this.method_18(num);
		}

		private void butRplus_Click(object sender, EventArgs e)
		{
			this.method_18(Convert.ToInt32(this.inputR.Text));
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			int num = -1 * Convert.ToInt32(this.inputSY.Text);
			this.method_17(0, num);
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.inputSY.Text);
			this.method_17(0, num);
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			int num = -1 * Convert.ToInt32(this.inputSX.Text);
			if (!this.bool_9)
			{
				this.method_17(num, 0);
				return;
			}
			this.method_17(num, num);
		}

		private void button_3_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.inputSX.Text);
			if (!this.bool_9)
			{
				this.method_17(num, 0);
				return;
			}
			this.method_17(num, num);
		}

		private void button_steal_Click(object sender, EventArgs e)
		{
			this.method_25();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_5();
				this.method_2(Convert.ToInt32(this.layerPanel2.Value));
				this.method_3();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_6();
				this.method_2(Convert.ToInt32(this.layerPanel3.Value));
				this.method_3();
			}
		}

		private void button27_Click(object sender, EventArgs e)
		{
			this.bool_13 = true;
			this.label12.Text = "VinylsData folder";
			this.saveButton.Enabled = true;
			this.uploadButton.Enabled = true;
			this.method_21();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_6();
				this.method_2(Convert.ToInt32(this.layerPanel1.Value));
				this.method_3();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (this.bool_9)
			{
				this.bool_9 = false;
				this.button_1.Enabled = true;
				this.button_0.Enabled = true;
				this.inputSY.Enabled = true;
				return;
			}
			this.bool_9 = true;
			this.button_1.Enabled = false;
			this.button_0.Enabled = false;
			this.inputSY.Enabled = false;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.pjeyWarbaH();
		}

		private void butXminus_Click(object sender, EventArgs e)
		{
			int num = -1 * Convert.ToInt32(this.inputX.Text);
			this.method_16(num, 0);
		}

		private void butXplus_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.inputX.Text);
			this.method_16(num, 0);
		}

		private void butYminus_Click(object sender, EventArgs e)
		{
			int num = -1 * Convert.ToInt32(this.inputY.Text);
			this.method_16(0, num);
		}

		private void butYplus_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.inputY.Text);
			this.method_16(0, num);
		}

		private void colorFilterButton_Click(object sender, EventArgs e)
		{
			this.method_19();
		}

		private void colorFilterh_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.colorFilterh.Value);
			if (num < 0)
			{
				this.colorFilterh.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.colorFilterh.Value = new decimal(0);
			}
		}

		private void colorFilterLive_Click(object sender, EventArgs e)
		{
			this.bool_10 = !this.bool_10;
			if (this.bool_10)
			{
				this.colorFilterLive.Text = "Man.";
				return;
			}
			this.colorFilterLive.Text = "Live";
		}

		private void colorSetToh_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.colorSetToh.Value);
			if (num < 0)
			{
				this.colorSetToh.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.colorSetToh.Value = new decimal(0);
			}
			if (this.bool_10)
			{
				this.method_19();
			}
		}

		private void colorSetTox_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_10)
			{
				this.method_19();
			}
		}

		private void colorSetToy_ValueChanged(object sender, EventArgs e)
		{
			if (this.bool_10)
			{
				this.method_19();
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (this.bool_13)
			{
				if (this.listBox1.SelectedIndex == -1)
				{
					MessageBox.Show("File not selected", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (MessageBox.Show(string.Concat("Do you want delete \"", this.listBox1.SelectedItem, "\" vinyl?"), "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
				{
					string str = string.Concat(Directory.GetCurrentDirectory(), "\\VinylsDataNew\\");
					if (File.Exists(string.Concat(str, this.listBox1.SelectedItem, ".svs")))
					{
						File.Delete(string.Concat(str, this.listBox1.SelectedItem, ".svs"));
					}
					this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
					return;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_15();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.delegate1_0 = new Form1.Delegate1(this.method_8);
			this.delegate2_0 = new Form1.Delegate2(this.method_11);
			this.delegate3_0 = new Form1.Delegate3(this.method_12);
			this.delegate4_0 = new Form1.Delegate4(this.method_13);
			this.delegate5_0 = new Form1.Delegate5(this.method_14);
			this.delegate6_0 = new Form1.Delegate6(this.method_10);
			this.delegate7_0 = new Form1.Delegate7(this.method_9);
			this.thread_0 = new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = false
			};
			this.thread_0.Start();
			this.method_21();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			SolidBrush solidBrush;
			Graphics graphic = base.CreateGraphics();
			solidBrush = (this.bool_0 ? new SolidBrush(Color.LimeGreen) : new SolidBrush(Color.Red));
			graphic.FillRectangle(solidBrush, new Rectangle(0, 0, 360, 5));
		}

		public bool GetBit(int b, int bitNumber)
		{
			if (bitNumber >= 32 || bitNumber <= 0)
			{
				return false;
			}
			return (b & 1 << (bitNumber - 1 & 31)) != 0;
		}

		private void icTyOjsByk(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_7();
				this.method_2(Convert.ToInt32(this.layerPanel2.Value));
				this.method_3();
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.layerPanel1 = new NumericUpDown();
			this.groupBox1 = new GroupBox();
			this.layerPanel1c4y = new NumericUpDown();
			this.layerPanel1c4x = new NumericUpDown();
			this.layerPanel1c4h = new NumericUpDown();
			this.layerPanel1c3y = new NumericUpDown();
			this.layerPanel1c3x = new NumericUpDown();
			this.layerPanel1c3h = new NumericUpDown();
			this.layerPanel1c2y = new NumericUpDown();
			this.layerPanel1c2x = new NumericUpDown();
			this.layerPanel1c2h = new NumericUpDown();
			this.layerPanel1c1y = new NumericUpDown();
			this.layerPanel1c1x = new NumericUpDown();
			this.layerPanel1c1h = new NumericUpDown();
			this.layerPanel1s = new NumericUpDown();
			this.layerPanel1r = new NumericUpDown();
			this.layerPanel1sY = new NumericUpDown();
			this.layerPanel1sX = new NumericUpDown();
			this.layerPanel1Y = new NumericUpDown();
			this.layerPanel1X = new NumericUpDown();
			this.groupBox2 = new GroupBox();
			this.label29 = new Label();
			this.layerPanel3c4y = new NumericUpDown();
			this.layerPanel3 = new NumericUpDown();
			this.layerPanel3c4x = new NumericUpDown();
			this.layerPanel3X = new NumericUpDown();
			this.layerPanel3c4h = new NumericUpDown();
			this.layerPanel3Y = new NumericUpDown();
			this.layerPanel3c3y = new NumericUpDown();
			this.layerPanel3sX = new NumericUpDown();
			this.BdsEcsiibb = new NumericUpDown();
			this.layerPanel3sY = new NumericUpDown();
			this.layerPanel3c3h = new NumericUpDown();
			this.layerPanel3r = new NumericUpDown();
			this.layerPanel3c2y = new NumericUpDown();
			this.layerPanel3s = new NumericUpDown();
			this.layerPanel3c2x = new NumericUpDown();
			this.layerPanel3c1h = new NumericUpDown();
			this.layerPanel3c2h = new NumericUpDown();
			this.layerPanel3c1x = new NumericUpDown();
			this.layerPanel3c1y = new NumericUpDown();
			this.layerPanel2c4y = new NumericUpDown();
			this.layerPanel2 = new NumericUpDown();
			this.layerPanel2c4x = new NumericUpDown();
			this.layerPanel2X = new NumericUpDown();
			this.layerPanel2c4h = new NumericUpDown();
			this.layerPanel2Y = new NumericUpDown();
			this.layerPanel2c3y = new NumericUpDown();
			this.layerPanel2sX = new NumericUpDown();
			this.layerPanel2c3x = new NumericUpDown();
			this.layerPanel2sY = new NumericUpDown();
			this.layerPanel2c3h = new NumericUpDown();
			this.layerPanel2r = new NumericUpDown();
			this.layerPanel2c2y = new NumericUpDown();
			this.layerPanel2s = new NumericUpDown();
			this.layerPanel2c2x = new NumericUpDown();
			this.layerPanel2c1h = new NumericUpDown();
			this.layerPanel2c2h = new NumericUpDown();
			this.layerPanel2c1x = new NumericUpDown();
			this.layerPanel2c1y = new NumericUpDown();
			this.label1 = new Label();
			this.groupBox3 = new GroupBox();
			this.button4 = new Button();
			this.lLayersA = new Label();
			this.lLayersC = new Label();
			this.butReCenter = new Button();
			this.refreshAuto = new Button();
			this.MirrorButton = new Button();
			this.label17 = new Label();
			this.layerToMirror = new NumericUpDown();
			this.colorFilterLive = new Button();
			this.colorFilterButton = new Button();
			this.label12 = new Label();
			this.label16 = new Label();
			this.label15 = new Label();
			this.colorSetToy = new NumericUpDown();
			this.colorSetTox = new NumericUpDown();
			this.colorSetToh = new NumericUpDown();
			this.colorFiltery = new NumericUpDown();
			this.colorFilterx = new NumericUpDown();
			this.colorFilterh = new NumericUpDown();
			this.inputR = new TextBox();
			this.inputSY = new TextBox();
			this.inputSX = new TextBox();
			this.inputY = new TextBox();
			this.inputX = new TextBox();
			this.butRminus = new Button();
			this.butRplus = new Button();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.butYminus = new Button();
			this.butYplus = new Button();
			this.butXminus = new Button();
			this.butXplus = new Button();
			this.label14 = new Label();
			this.label13 = new Label();
			this.button6 = new Button();
			this.button1 = new Button();
			this.button3 = new Button();
			this.button2 = new Button();
			this.label11 = new Label();
			this.label10 = new Label();
			this.label9 = new Label();
			this.label8 = new Label();
			this.label7 = new Label();
			this.label6 = new Label();
			this.label5 = new Label();
			this.DyxZieVhnS = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.listBox1 = new ListBox();
			this.loadButton = new Button();
			this.saveButton = new Button();
			this.label18 = new Label();
			this.LoadFromLayer = new NumericUpDown();
			this.LoadToLayer = new Label();
			this.label20 = new Label();
			this.label21 = new Label();
			this.SaveFromLayer = new NumericUpDown();
			this.SaveToLayer = new NumericUpDown();
			this.label22 = new Label();
			this.label23 = new Label();
			this.OeMxuosSgo = new TextBox();
			this.label24 = new Label();
			this.uploadButton = new Button();
			this.deleteButton = new Button();
			this.groupBox4 = new GroupBox();
			this.loadDesc = new Label();
			this.label32 = new Label();
			this.loadAuthor = new Label();
			this.dqmheTawJe = new Label();
			this.label28 = new Label();
			this.saveDesc = new TextBox();
			this.playerNameLabel = new Label();
			this.refreshFolder = new Button();
			this.label27 = new Label();
			this.saveAuthor = new TextBox();
			this.label25 = new Label();
			this.button27 = new Button();
			this.button5 = new Button();
			this.label26 = new Label();
			this.button_steal = new Button();
			this.logger = new RichTextBox();
			((ISupportInitialize)this.layerPanel1).BeginInit();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.layerPanel1c4y).BeginInit();
			((ISupportInitialize)this.layerPanel1c4x).BeginInit();
			((ISupportInitialize)this.layerPanel1c4h).BeginInit();
			((ISupportInitialize)this.layerPanel1c3y).BeginInit();
			((ISupportInitialize)this.layerPanel1c3x).BeginInit();
			((ISupportInitialize)this.layerPanel1c3h).BeginInit();
			((ISupportInitialize)this.layerPanel1c2y).BeginInit();
			((ISupportInitialize)this.layerPanel1c2x).BeginInit();
			((ISupportInitialize)this.layerPanel1c2h).BeginInit();
			((ISupportInitialize)this.layerPanel1c1y).BeginInit();
			((ISupportInitialize)this.layerPanel1c1x).BeginInit();
			((ISupportInitialize)this.layerPanel1c1h).BeginInit();
			((ISupportInitialize)this.layerPanel1s).BeginInit();
			((ISupportInitialize)this.layerPanel1r).BeginInit();
			((ISupportInitialize)this.layerPanel1sY).BeginInit();
			((ISupportInitialize)this.layerPanel1sX).BeginInit();
			((ISupportInitialize)this.layerPanel1Y).BeginInit();
			((ISupportInitialize)this.layerPanel1X).BeginInit();
			this.groupBox2.SuspendLayout();
			((ISupportInitialize)this.layerPanel3c4y).BeginInit();
			((ISupportInitialize)this.layerPanel3).BeginInit();
			((ISupportInitialize)this.layerPanel3c4x).BeginInit();
			((ISupportInitialize)this.layerPanel3X).BeginInit();
			((ISupportInitialize)this.layerPanel3c4h).BeginInit();
			((ISupportInitialize)this.layerPanel3Y).BeginInit();
			((ISupportInitialize)this.layerPanel3c3y).BeginInit();
			((ISupportInitialize)this.layerPanel3sX).BeginInit();
			((ISupportInitialize)this.BdsEcsiibb).BeginInit();
			((ISupportInitialize)this.layerPanel3sY).BeginInit();
			((ISupportInitialize)this.layerPanel3c3h).BeginInit();
			((ISupportInitialize)this.layerPanel3r).BeginInit();
			((ISupportInitialize)this.layerPanel3c2y).BeginInit();
			((ISupportInitialize)this.layerPanel3s).BeginInit();
			((ISupportInitialize)this.layerPanel3c2x).BeginInit();
			((ISupportInitialize)this.layerPanel3c1h).BeginInit();
			((ISupportInitialize)this.layerPanel3c2h).BeginInit();
			((ISupportInitialize)this.layerPanel3c1x).BeginInit();
			((ISupportInitialize)this.layerPanel3c1y).BeginInit();
			((ISupportInitialize)this.layerPanel2c4y).BeginInit();
			((ISupportInitialize)this.layerPanel2).BeginInit();
			((ISupportInitialize)this.layerPanel2c4x).BeginInit();
			((ISupportInitialize)this.layerPanel2X).BeginInit();
			((ISupportInitialize)this.layerPanel2c4h).BeginInit();
			((ISupportInitialize)this.layerPanel2Y).BeginInit();
			((ISupportInitialize)this.layerPanel2c3y).BeginInit();
			((ISupportInitialize)this.layerPanel2sX).BeginInit();
			((ISupportInitialize)this.layerPanel2c3x).BeginInit();
			((ISupportInitialize)this.layerPanel2sY).BeginInit();
			((ISupportInitialize)this.layerPanel2c3h).BeginInit();
			((ISupportInitialize)this.layerPanel2r).BeginInit();
			((ISupportInitialize)this.layerPanel2c2y).BeginInit();
			((ISupportInitialize)this.layerPanel2s).BeginInit();
			((ISupportInitialize)this.layerPanel2c2x).BeginInit();
			((ISupportInitialize)this.layerPanel2c1h).BeginInit();
			((ISupportInitialize)this.layerPanel2c2h).BeginInit();
			((ISupportInitialize)this.layerPanel2c1x).BeginInit();
			((ISupportInitialize)this.layerPanel2c1y).BeginInit();
			this.groupBox3.SuspendLayout();
			((ISupportInitialize)this.layerToMirror).BeginInit();
			((ISupportInitialize)this.colorSetToy).BeginInit();
			((ISupportInitialize)this.colorSetTox).BeginInit();
			((ISupportInitialize)this.colorSetToh).BeginInit();
			((ISupportInitialize)this.colorFiltery).BeginInit();
			((ISupportInitialize)this.colorFilterx).BeginInit();
			((ISupportInitialize)this.colorFilterh).BeginInit();
			((ISupportInitialize)this.LoadFromLayer).BeginInit();
			((ISupportInitialize)this.SaveFromLayer).BeginInit();
			((ISupportInitialize)this.SaveToLayer).BeginInit();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.layerPanel1.Location = new Point(19, 20);
			NumericUpDown num = this.layerPanel1;
			int[] numArray = new int[] { 31, 0, 0, 0 };
			num.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown = this.layerPanel1;
			int[] numArray1 = new int[] { 1, 0, 0, 0 };
			numericUpDown.Minimum = new decimal(numArray1);
			this.layerPanel1.Name = "layerPanel1";
			this.layerPanel1.Size = new System.Drawing.Size(35, 20);
			this.layerPanel1.TabIndex = 0;
			NumericUpDown num1 = this.layerPanel1;
			int[] numArray2 = new int[] { 1, 0, 0, 0 };
			num1.Value = new decimal(numArray2);
			this.layerPanel1.ValueChanged += new EventHandler(this.layerPanel1_ValueChanged);
			this.groupBox1.BackColor = SystemColors.Control;
			this.groupBox1.Controls.Add(this.layerPanel1c4y);
			this.groupBox1.Controls.Add(this.layerPanel1c4x);
			this.groupBox1.Controls.Add(this.layerPanel1c4h);
			this.groupBox1.Controls.Add(this.layerPanel1c3y);
			this.groupBox1.Controls.Add(this.layerPanel1c3x);
			this.groupBox1.Controls.Add(this.layerPanel1c3h);
			this.groupBox1.Controls.Add(this.layerPanel1c2y);
			this.groupBox1.Controls.Add(this.layerPanel1c2x);
			this.groupBox1.Controls.Add(this.layerPanel1c2h);
			this.groupBox1.Controls.Add(this.layerPanel1c1y);
			this.groupBox1.Controls.Add(this.layerPanel1c1x);
			this.groupBox1.Controls.Add(this.layerPanel1c1h);
			this.groupBox1.Controls.Add(this.layerPanel1s);
			this.groupBox1.Controls.Add(this.layerPanel1r);
			this.groupBox1.Controls.Add(this.layerPanel1sY);
			this.groupBox1.Controls.Add(this.layerPanel1sX);
			this.groupBox1.Controls.Add(this.layerPanel1Y);
			this.groupBox1.Controls.Add(this.layerPanel1X);
			this.groupBox1.Controls.Add(this.layerPanel1);
			this.groupBox1.Location = new Point(48, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(78, 443);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Simple layer";
			this.layerPanel1c4y.Location = new Point(9, 415);
			NumericUpDown numericUpDown1 = this.layerPanel1c4y;
			int[] numArray3 = new int[] { 255, 0, 0, 0 };
			numericUpDown1.Maximum = new decimal(numArray3);
			this.layerPanel1c4y.Name = "layerPanel1c4y";
			this.layerPanel1c4y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c4y.TabIndex = 21;
			this.layerPanel1c4y.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c4y.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c4y.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c4x.Location = new Point(9, 395);
			NumericUpDown num2 = this.layerPanel1c4x;
			int[] numArray4 = new int[] { 255, 0, 0, 0 };
			num2.Maximum = new decimal(numArray4);
			this.layerPanel1c4x.Name = "layerPanel1c4x";
			this.layerPanel1c4x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c4x.TabIndex = 20;
			this.layerPanel1c4x.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c4x.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c4x.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c4h.Location = new Point(9, 375);
			NumericUpDown numericUpDown2 = this.layerPanel1c4h;
			int[] numArray5 = new int[] { 90, 0, 0, 0 };
			numericUpDown2.Maximum = new decimal(numArray5);
			NumericUpDown num3 = this.layerPanel1c4h;
			int[] numArray6 = new int[] { 1, 0, 0, -2147483648 };
			num3.Minimum = new decimal(numArray6);
			this.layerPanel1c4h.Name = "layerPanel1c4h";
			this.layerPanel1c4h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c4h.TabIndex = 19;
			this.layerPanel1c4h.ValueChanged += new EventHandler(this.layerPanel1c4h_ValueChanged);
			this.layerPanel1c4h.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c4h.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c3y.Location = new Point(9, 350);
			NumericUpDown numericUpDown3 = this.layerPanel1c3y;
			int[] numArray7 = new int[] { 255, 0, 0, 0 };
			numericUpDown3.Maximum = new decimal(numArray7);
			this.layerPanel1c3y.Name = "layerPanel1c3y";
			this.layerPanel1c3y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c3y.TabIndex = 18;
			this.layerPanel1c3y.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c3y.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c3y.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c3x.Location = new Point(9, 330);
			NumericUpDown num4 = this.layerPanel1c3x;
			int[] numArray8 = new int[] { 255, 0, 0, 0 };
			num4.Maximum = new decimal(numArray8);
			this.layerPanel1c3x.Name = "layerPanel1c3x";
			this.layerPanel1c3x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c3x.TabIndex = 17;
			this.layerPanel1c3x.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c3x.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c3x.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c3h.Location = new Point(9, 310);
			NumericUpDown numericUpDown4 = this.layerPanel1c3h;
			int[] numArray9 = new int[] { 90, 0, 0, 0 };
			numericUpDown4.Maximum = new decimal(numArray9);
			NumericUpDown num5 = this.layerPanel1c3h;
			int[] numArray10 = new int[] { 1, 0, 0, -2147483648 };
			num5.Minimum = new decimal(numArray10);
			this.layerPanel1c3h.Name = "layerPanel1c3h";
			this.layerPanel1c3h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c3h.TabIndex = 16;
			this.layerPanel1c3h.ValueChanged += new EventHandler(this.layerPanel1c3h_ValueChanged);
			this.layerPanel1c3h.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c3h.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c2y.Location = new Point(9, 285);
			NumericUpDown numericUpDown5 = this.layerPanel1c2y;
			int[] numArray11 = new int[] { 255, 0, 0, 0 };
			numericUpDown5.Maximum = new decimal(numArray11);
			this.layerPanel1c2y.Name = "layerPanel1c2y";
			this.layerPanel1c2y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c2y.TabIndex = 15;
			this.layerPanel1c2y.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c2y.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c2y.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c2x.Location = new Point(9, 265);
			NumericUpDown num6 = this.layerPanel1c2x;
			int[] numArray12 = new int[] { 255, 0, 0, 0 };
			num6.Maximum = new decimal(numArray12);
			this.layerPanel1c2x.Name = "layerPanel1c2x";
			this.layerPanel1c2x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c2x.TabIndex = 14;
			this.layerPanel1c2x.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c2x.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c2x.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c2h.Location = new Point(9, 245);
			NumericUpDown numericUpDown6 = this.layerPanel1c2h;
			int[] numArray13 = new int[] { 90, 0, 0, 0 };
			numericUpDown6.Maximum = new decimal(numArray13);
			NumericUpDown num7 = this.layerPanel1c2h;
			int[] numArray14 = new int[] { 1, 0, 0, -2147483648 };
			num7.Minimum = new decimal(numArray14);
			this.layerPanel1c2h.Name = "layerPanel1c2h";
			this.layerPanel1c2h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c2h.TabIndex = 13;
			this.layerPanel1c2h.ValueChanged += new EventHandler(this.layerPanel1c2h_ValueChanged);
			this.layerPanel1c2h.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c2h.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c1y.Location = new Point(9, 220);
			NumericUpDown numericUpDown7 = this.layerPanel1c1y;
			int[] numArray15 = new int[] { 255, 0, 0, 0 };
			numericUpDown7.Maximum = new decimal(numArray15);
			this.layerPanel1c1y.Name = "layerPanel1c1y";
			this.layerPanel1c1y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c1y.TabIndex = 12;
			this.layerPanel1c1y.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c1y.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c1y.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c1x.Location = new Point(9, 200);
			NumericUpDown num8 = this.layerPanel1c1x;
			int[] numArray16 = new int[] { 255, 0, 0, 0 };
			num8.Maximum = new decimal(numArray16);
			this.layerPanel1c1x.Name = "layerPanel1c1x";
			this.layerPanel1c1x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c1x.TabIndex = 11;
			this.layerPanel1c1x.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1c1x.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c1x.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1c1h.Location = new Point(9, 180);
			NumericUpDown numericUpDown8 = this.layerPanel1c1h;
			int[] numArray17 = new int[] { 90, 0, 0, 0 };
			numericUpDown8.Maximum = new decimal(numArray17);
			NumericUpDown num9 = this.layerPanel1c1h;
			int[] numArray18 = new int[] { 1, 0, 0, -2147483648 };
			num9.Minimum = new decimal(numArray18);
			this.layerPanel1c1h.Name = "layerPanel1c1h";
			this.layerPanel1c1h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1c1h.TabIndex = 10;
			this.layerPanel1c1h.ValueChanged += new EventHandler(this.layerPanel1c1h_ValueChanged);
			this.layerPanel1c1h.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1c1h.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1s.Location = new Point(9, 155);
			NumericUpDown numericUpDown9 = this.layerPanel1s;
			int[] numArray19 = new int[] { 255, 0, 0, 0 };
			numericUpDown9.Maximum = new decimal(numArray19);
			this.layerPanel1s.Name = "layerPanel1s";
			this.layerPanel1s.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1s.TabIndex = 9;
			this.layerPanel1s.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1s.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1s.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1r.Location = new Point(9, 135);
			NumericUpDown num10 = this.layerPanel1r;
			int[] numArray20 = new int[] { 256, 0, 0, 0 };
			num10.Maximum = new decimal(numArray20);
			NumericUpDown numericUpDown10 = this.layerPanel1r;
			int[] numArray21 = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown10.Minimum = new decimal(numArray21);
			this.layerPanel1r.Name = "layerPanel1r";
			this.layerPanel1r.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1r.TabIndex = 8;
			this.layerPanel1r.ValueChanged += new EventHandler(this.layerPanel1r_ValueChanged);
			this.layerPanel1r.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1r.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1sY.Location = new Point(9, 110);
			NumericUpDown num11 = this.layerPanel1sY;
			int[] numArray22 = new int[] { -1, 0, 0, 0 };
			num11.Maximum = new decimal(numArray22);
			this.layerPanel1sY.Name = "layerPanel1sY";
			this.layerPanel1sY.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1sY.TabIndex = 7;
			this.layerPanel1sY.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1sY.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1sY.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1sX.Location = new Point(9, 90);
			NumericUpDown numericUpDown11 = this.layerPanel1sX;
			int[] numArray23 = new int[] { -1, 0, 0, 0 };
			numericUpDown11.Maximum = new decimal(numArray23);
			this.layerPanel1sX.Name = "layerPanel1sX";
			this.layerPanel1sX.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1sX.TabIndex = 6;
			this.layerPanel1sX.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1sX.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1sX.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1Y.Location = new Point(9, 65);
			NumericUpDown num12 = this.layerPanel1Y;
			int[] numArray24 = new int[] { 2147483647, 0, 0, 0 };
			num12.Maximum = new decimal(numArray24);
			NumericUpDown numericUpDown12 = this.layerPanel1Y;
			int[] numArray25 = new int[] { -2147483648, 0, 0, -2147483648 };
			numericUpDown12.Minimum = new decimal(numArray25);
			this.layerPanel1Y.Name = "layerPanel1Y";
			this.layerPanel1Y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1Y.TabIndex = 5;
			this.layerPanel1Y.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1Y.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1Y.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.layerPanel1X.Location = new Point(9, 45);
			NumericUpDown num13 = this.layerPanel1X;
			int[] numArray26 = new int[] { 2147483647, 0, 0, 0 };
			num13.Maximum = new decimal(numArray26);
			NumericUpDown numericUpDown13 = this.layerPanel1X;
			int[] numArray27 = new int[] { -2147483648, 0, 0, -2147483648 };
			numericUpDown13.Minimum = new decimal(numArray27);
			this.layerPanel1X.Name = "layerPanel1X";
			this.layerPanel1X.Size = new System.Drawing.Size(60, 20);
			this.layerPanel1X.TabIndex = 1;
			this.layerPanel1X.ValueChanged += new EventHandler(this.RaNyhyUqHk);
			this.layerPanel1X.Enter += new EventHandler(this.layerPanel1X_Enter);
			this.layerPanel1X.Leave += new EventHandler(this.layerPanel1X_Leave);
			this.groupBox2.BackColor = SystemColors.Control;
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.layerPanel3c4y);
			this.groupBox2.Controls.Add(this.layerPanel3);
			this.groupBox2.Controls.Add(this.layerPanel3c4x);
			this.groupBox2.Controls.Add(this.layerPanel3X);
			this.groupBox2.Controls.Add(this.layerPanel3c4h);
			this.groupBox2.Controls.Add(this.layerPanel3Y);
			this.groupBox2.Controls.Add(this.layerPanel3c3y);
			this.groupBox2.Controls.Add(this.layerPanel3sX);
			this.groupBox2.Controls.Add(this.BdsEcsiibb);
			this.groupBox2.Controls.Add(this.layerPanel3sY);
			this.groupBox2.Controls.Add(this.layerPanel3c3h);
			this.groupBox2.Controls.Add(this.layerPanel3r);
			this.groupBox2.Controls.Add(this.layerPanel3c2y);
			this.groupBox2.Controls.Add(this.layerPanel3s);
			this.groupBox2.Controls.Add(this.layerPanel3c2x);
			this.groupBox2.Controls.Add(this.layerPanel3c1h);
			this.groupBox2.Controls.Add(this.layerPanel3c2h);
			this.groupBox2.Controls.Add(this.layerPanel3c1x);
			this.groupBox2.Controls.Add(this.layerPanel3c1y);
			this.groupBox2.Controls.Add(this.layerPanel2c4y);
			this.groupBox2.Controls.Add(this.layerPanel2);
			this.groupBox2.Controls.Add(this.layerPanel2c4x);
			this.groupBox2.Controls.Add(this.layerPanel2X);
			this.groupBox2.Controls.Add(this.layerPanel2c4h);
			this.groupBox2.Controls.Add(this.layerPanel2Y);
			this.groupBox2.Controls.Add(this.layerPanel2c3y);
			this.groupBox2.Controls.Add(this.layerPanel2sX);
			this.groupBox2.Controls.Add(this.layerPanel2c3x);
			this.groupBox2.Controls.Add(this.layerPanel2sY);
			this.groupBox2.Controls.Add(this.layerPanel2c3h);
			this.groupBox2.Controls.Add(this.layerPanel2r);
			this.groupBox2.Controls.Add(this.layerPanel2c2y);
			this.groupBox2.Controls.Add(this.layerPanel2s);
			this.groupBox2.Controls.Add(this.layerPanel2c2x);
			this.groupBox2.Controls.Add(this.layerPanel2c1h);
			this.groupBox2.Controls.Add(this.layerPanel2c2h);
			this.groupBox2.Controls.Add(this.layerPanel2c1x);
			this.groupBox2.Controls.Add(this.layerPanel2c1y);
			this.groupBox2.Location = new Point(129, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 443);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Group layers";
			this.label29.AutoSize = true;
			this.label29.Location = new Point(65, 23);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(19, 13);
			this.label29.TabIndex = 93;
			this.label29.Text = "----";
			this.layerPanel3c4y.Location = new Point(81, 415);
			NumericUpDown num14 = this.layerPanel3c4y;
			int[] numArray28 = new int[] { 255, 0, 0, 0 };
			num14.Maximum = new decimal(numArray28);
			this.layerPanel3c4y.Name = "layerPanel3c4y";
			this.layerPanel3c4y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c4y.TabIndex = 59;
			this.layerPanel3c4y.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c4y.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c4y.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3.Location = new Point(91, 20);
			NumericUpDown numericUpDown14 = this.layerPanel3;
			int[] numArray29 = new int[] { 31, 0, 0, 0 };
			numericUpDown14.Maximum = new decimal(numArray29);
			NumericUpDown num15 = this.layerPanel3;
			int[] numArray30 = new int[] { 1, 0, 0, 0 };
			num15.Minimum = new decimal(numArray30);
			this.layerPanel3.Name = "layerPanel3";
			this.layerPanel3.Size = new System.Drawing.Size(35, 20);
			this.layerPanel3.TabIndex = 41;
			NumericUpDown numericUpDown15 = this.layerPanel3;
			int[] numArray31 = new int[] { 3, 0, 0, 0 };
			numericUpDown15.Value = new decimal(numArray31);
			this.layerPanel3.ValueChanged += new EventHandler(this.layerPanel3_ValueChanged);
			this.layerPanel3c4x.Location = new Point(81, 395);
			NumericUpDown num16 = this.layerPanel3c4x;
			int[] numArray32 = new int[] { 255, 0, 0, 0 };
			num16.Maximum = new decimal(numArray32);
			this.layerPanel3c4x.Name = "layerPanel3c4x";
			this.layerPanel3c4x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c4x.TabIndex = 58;
			this.layerPanel3c4x.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c4x.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c4x.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3X.Location = new Point(81, 45);
			NumericUpDown numericUpDown16 = this.layerPanel3X;
			int[] numArray33 = new int[] { 2147483647, 0, 0, 0 };
			numericUpDown16.Maximum = new decimal(numArray33);
			NumericUpDown num17 = this.layerPanel3X;
			int[] numArray34 = new int[] { -2147483648, 0, 0, -2147483648 };
			num17.Minimum = new decimal(numArray34);
			this.layerPanel3X.Name = "layerPanel3X";
			this.layerPanel3X.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3X.TabIndex = 42;
			this.layerPanel3X.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3X.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3X.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c4h.Location = new Point(81, 375);
			NumericUpDown numericUpDown17 = this.layerPanel3c4h;
			int[] numArray35 = new int[] { 90, 0, 0, 0 };
			numericUpDown17.Maximum = new decimal(numArray35);
			NumericUpDown num18 = this.layerPanel3c4h;
			int[] numArray36 = new int[] { 1, 0, 0, -2147483648 };
			num18.Minimum = new decimal(numArray36);
			this.layerPanel3c4h.Name = "layerPanel3c4h";
			this.layerPanel3c4h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c4h.TabIndex = 57;
			this.layerPanel3c4h.ValueChanged += new EventHandler(this.XplefkUpyX);
			this.layerPanel3c4h.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c4h.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3Y.Location = new Point(81, 65);
			NumericUpDown numericUpDown18 = this.layerPanel3Y;
			int[] numArray37 = new int[] { 2147483647, 0, 0, 0 };
			numericUpDown18.Maximum = new decimal(numArray37);
			NumericUpDown num19 = this.layerPanel3Y;
			int[] numArray38 = new int[] { -2147483648, 0, 0, -2147483648 };
			num19.Minimum = new decimal(numArray38);
			this.layerPanel3Y.Name = "layerPanel3Y";
			this.layerPanel3Y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3Y.TabIndex = 43;
			this.layerPanel3Y.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3Y.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3Y.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c3y.Location = new Point(81, 350);
			NumericUpDown numericUpDown19 = this.layerPanel3c3y;
			int[] numArray39 = new int[] { 255, 0, 0, 0 };
			numericUpDown19.Maximum = new decimal(numArray39);
			this.layerPanel3c3y.Name = "layerPanel3c3y";
			this.layerPanel3c3y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c3y.TabIndex = 56;
			this.layerPanel3c3y.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c3y.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c3y.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3sX.Location = new Point(81, 90);
			NumericUpDown num20 = this.layerPanel3sX;
			int[] numArray40 = new int[] { -1, 0, 0, 0 };
			num20.Maximum = new decimal(numArray40);
			this.layerPanel3sX.Name = "layerPanel3sX";
			this.layerPanel3sX.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3sX.TabIndex = 44;
			this.layerPanel3sX.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3sX.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3sX.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.BdsEcsiibb.Location = new Point(81, 330);
			NumericUpDown bdsEcsiibb = this.BdsEcsiibb;
			int[] numArray41 = new int[] { 255, 0, 0, 0 };
			bdsEcsiibb.Maximum = new decimal(numArray41);
			this.BdsEcsiibb.Name = "layerPanel3c3x";
			this.BdsEcsiibb.Size = new System.Drawing.Size(60, 20);
			this.BdsEcsiibb.TabIndex = 55;
			this.BdsEcsiibb.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.BdsEcsiibb.Enter += new EventHandler(this.rvByEaweAH);
			this.BdsEcsiibb.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3sY.Location = new Point(81, 110);
			NumericUpDown numericUpDown20 = this.layerPanel3sY;
			int[] numArray42 = new int[] { -1, 0, 0, 0 };
			numericUpDown20.Maximum = new decimal(numArray42);
			this.layerPanel3sY.Name = "layerPanel3sY";
			this.layerPanel3sY.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3sY.TabIndex = 45;
			this.layerPanel3sY.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3sY.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3sY.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c3h.Location = new Point(81, 310);
			NumericUpDown num21 = this.layerPanel3c3h;
			int[] numArray43 = new int[] { 90, 0, 0, 0 };
			num21.Maximum = new decimal(numArray43);
			NumericUpDown numericUpDown21 = this.layerPanel3c3h;
			int[] numArray44 = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown21.Minimum = new decimal(numArray44);
			this.layerPanel3c3h.Name = "layerPanel3c3h";
			this.layerPanel3c3h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c3h.TabIndex = 54;
			this.layerPanel3c3h.ValueChanged += new EventHandler(this.layerPanel3c3h_ValueChanged);
			this.layerPanel3c3h.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c3h.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3r.Location = new Point(81, 135);
			NumericUpDown num22 = this.layerPanel3r;
			int[] numArray45 = new int[] { 256, 0, 0, 0 };
			num22.Maximum = new decimal(numArray45);
			NumericUpDown numericUpDown22 = this.layerPanel3r;
			int[] numArray46 = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown22.Minimum = new decimal(numArray46);
			this.layerPanel3r.Name = "layerPanel3r";
			this.layerPanel3r.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3r.TabIndex = 46;
			this.layerPanel3r.ValueChanged += new EventHandler(this.layerPanel3r_ValueChanged);
			this.layerPanel3r.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3r.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c2y.Location = new Point(81, 285);
			NumericUpDown num23 = this.layerPanel3c2y;
			int[] numArray47 = new int[] { 255, 0, 0, 0 };
			num23.Maximum = new decimal(numArray47);
			this.layerPanel3c2y.Name = "layerPanel3c2y";
			this.layerPanel3c2y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c2y.TabIndex = 53;
			this.layerPanel3c2y.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c2y.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c2y.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3s.Location = new Point(81, 155);
			NumericUpDown numericUpDown23 = this.layerPanel3s;
			int[] numArray48 = new int[] { 255, 0, 0, 0 };
			numericUpDown23.Maximum = new decimal(numArray48);
			this.layerPanel3s.Name = "layerPanel3s";
			this.layerPanel3s.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3s.TabIndex = 47;
			this.layerPanel3s.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3s.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3s.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c2x.Location = new Point(81, 265);
			NumericUpDown num24 = this.layerPanel3c2x;
			int[] numArray49 = new int[] { 255, 0, 0, 0 };
			num24.Maximum = new decimal(numArray49);
			this.layerPanel3c2x.Name = "layerPanel3c2x";
			this.layerPanel3c2x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c2x.TabIndex = 52;
			this.layerPanel3c2x.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c2x.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c2x.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c1h.Location = new Point(81, 180);
			NumericUpDown numericUpDown24 = this.layerPanel3c1h;
			int[] numArray50 = new int[] { 90, 0, 0, 0 };
			numericUpDown24.Maximum = new decimal(numArray50);
			NumericUpDown num25 = this.layerPanel3c1h;
			int[] numArray51 = new int[] { 1, 0, 0, -2147483648 };
			num25.Minimum = new decimal(numArray51);
			this.layerPanel3c1h.Name = "layerPanel3c1h";
			this.layerPanel3c1h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c1h.TabIndex = 48;
			this.layerPanel3c1h.ValueChanged += new EventHandler(this.layerPanel3c1h_ValueChanged);
			this.layerPanel3c1h.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c1h.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c2h.Location = new Point(81, 245);
			NumericUpDown numericUpDown25 = this.layerPanel3c2h;
			int[] numArray52 = new int[] { 90, 0, 0, 0 };
			numericUpDown25.Maximum = new decimal(numArray52);
			NumericUpDown num26 = this.layerPanel3c2h;
			int[] numArray53 = new int[] { 1, 0, 0, -2147483648 };
			num26.Minimum = new decimal(numArray53);
			this.layerPanel3c2h.Name = "layerPanel3c2h";
			this.layerPanel3c2h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c2h.TabIndex = 51;
			this.layerPanel3c2h.ValueChanged += new EventHandler(this.layerPanel3c2h_ValueChanged);
			this.layerPanel3c2h.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c2h.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c1x.Location = new Point(81, 200);
			NumericUpDown numericUpDown26 = this.layerPanel3c1x;
			int[] numArray54 = new int[] { 255, 0, 0, 0 };
			numericUpDown26.Maximum = new decimal(numArray54);
			this.layerPanel3c1x.Name = "layerPanel3c1x";
			this.layerPanel3c1x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c1x.TabIndex = 49;
			this.layerPanel3c1x.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c1x.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c1x.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel3c1y.Location = new Point(81, 220);
			NumericUpDown num27 = this.layerPanel3c1y;
			int[] numArray55 = new int[] { 255, 0, 0, 0 };
			num27.Maximum = new decimal(numArray55);
			this.layerPanel3c1y.Name = "layerPanel3c1y";
			this.layerPanel3c1y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel3c1y.TabIndex = 50;
			this.layerPanel3c1y.ValueChanged += new EventHandler(this.layerPanel3c1y_ValueChanged);
			this.layerPanel3c1y.Enter += new EventHandler(this.rvByEaweAH);
			this.layerPanel3c1y.Leave += new EventHandler(this.layerPanel3c1y_Leave);
			this.layerPanel2c4y.Location = new Point(9, 415);
			NumericUpDown numericUpDown27 = this.layerPanel2c4y;
			int[] numArray56 = new int[] { 255, 0, 0, 0 };
			numericUpDown27.Maximum = new decimal(numArray56);
			this.layerPanel2c4y.Name = "layerPanel2c4y";
			this.layerPanel2c4y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c4y.TabIndex = 40;
			this.layerPanel2c4y.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c4y.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c4y.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2.Location = new Point(19, 20);
			NumericUpDown num28 = this.layerPanel2;
			int[] numArray57 = new int[] { 31, 0, 0, 0 };
			num28.Maximum = new decimal(numArray57);
			NumericUpDown numericUpDown28 = this.layerPanel2;
			int[] numArray58 = new int[] { 1, 0, 0, 0 };
			numericUpDown28.Minimum = new decimal(numArray58);
			this.layerPanel2.Name = "layerPanel2";
			this.layerPanel2.Size = new System.Drawing.Size(35, 20);
			this.layerPanel2.TabIndex = 22;
			NumericUpDown num29 = this.layerPanel2;
			int[] numArray59 = new int[] { 2, 0, 0, 0 };
			num29.Value = new decimal(numArray59);
			this.layerPanel2.ValueChanged += new EventHandler(this.layerPanel2_ValueChanged);
			this.layerPanel2c4x.Location = new Point(9, 395);
			NumericUpDown numericUpDown29 = this.layerPanel2c4x;
			numArray = new int[] { 255, 0, 0, 0 };
			numericUpDown29.Maximum = new decimal(numArray);
			this.layerPanel2c4x.Name = "layerPanel2c4x";
			this.layerPanel2c4x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c4x.TabIndex = 39;
			this.layerPanel2c4x.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c4x.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c4x.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2X.Location = new Point(9, 45);
			NumericUpDown num30 = this.layerPanel2X;
			numArray = new int[] { 2147483647, 0, 0, 0 };
			num30.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown30 = this.layerPanel2X;
			numArray = new int[] { -2147483648, 0, 0, -2147483648 };
			numericUpDown30.Minimum = new decimal(numArray);
			this.layerPanel2X.Name = "layerPanel2X";
			this.layerPanel2X.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2X.TabIndex = 23;
			this.layerPanel2X.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2X.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2X.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c4h.Location = new Point(9, 375);
			NumericUpDown num31 = this.layerPanel2c4h;
			numArray = new int[] { 90, 0, 0, 0 };
			num31.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown31 = this.layerPanel2c4h;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown31.Minimum = new decimal(numArray);
			this.layerPanel2c4h.Name = "layerPanel2c4h";
			this.layerPanel2c4h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c4h.TabIndex = 38;
			this.layerPanel2c4h.ValueChanged += new EventHandler(this.YxBeHdIhkb);
			this.layerPanel2c4h.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c4h.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2Y.Location = new Point(9, 65);
			NumericUpDown num32 = this.layerPanel2Y;
			numArray = new int[] { 2147483647, 0, 0, 0 };
			num32.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown32 = this.layerPanel2Y;
			numArray = new int[] { -2147483648, 0, 0, -2147483648 };
			numericUpDown32.Minimum = new decimal(numArray);
			this.layerPanel2Y.Name = "layerPanel2Y";
			this.layerPanel2Y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2Y.TabIndex = 24;
			this.layerPanel2Y.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2Y.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2Y.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c3y.Location = new Point(9, 350);
			NumericUpDown num33 = this.layerPanel2c3y;
			numArray = new int[] { 255, 0, 0, 0 };
			num33.Maximum = new decimal(numArray);
			this.layerPanel2c3y.Name = "layerPanel2c3y";
			this.layerPanel2c3y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c3y.TabIndex = 37;
			this.layerPanel2c3y.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c3y.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c3y.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2sX.Location = new Point(9, 90);
			NumericUpDown numericUpDown33 = this.layerPanel2sX;
			numArray = new int[] { -1, 0, 0, 0 };
			numericUpDown33.Maximum = new decimal(numArray);
			this.layerPanel2sX.Name = "layerPanel2sX";
			this.layerPanel2sX.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2sX.TabIndex = 25;
			this.layerPanel2sX.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2sX.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2sX.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c3x.Location = new Point(9, 330);
			NumericUpDown num34 = this.layerPanel2c3x;
			numArray = new int[] { 255, 0, 0, 0 };
			num34.Maximum = new decimal(numArray);
			this.layerPanel2c3x.Name = "layerPanel2c3x";
			this.layerPanel2c3x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c3x.TabIndex = 36;
			this.layerPanel2c3x.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c3x.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c3x.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2sY.Location = new Point(9, 110);
			NumericUpDown numericUpDown34 = this.layerPanel2sY;
			numArray = new int[] { -1, 0, 0, 0 };
			numericUpDown34.Maximum = new decimal(numArray);
			this.layerPanel2sY.Name = "layerPanel2sY";
			this.layerPanel2sY.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2sY.TabIndex = 26;
			this.layerPanel2sY.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2sY.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2sY.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c3h.Location = new Point(9, 310);
			NumericUpDown num35 = this.layerPanel2c3h;
			numArray = new int[] { 90, 0, 0, 0 };
			num35.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown35 = this.layerPanel2c3h;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown35.Minimum = new decimal(numArray);
			this.layerPanel2c3h.Name = "layerPanel2c3h";
			this.layerPanel2c3h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c3h.TabIndex = 35;
			this.layerPanel2c3h.ValueChanged += new EventHandler(this.layerPanel2c3h_ValueChanged);
			this.layerPanel2c3h.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c3h.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2r.Location = new Point(9, 135);
			NumericUpDown num36 = this.layerPanel2r;
			numArray = new int[] { 256, 0, 0, 0 };
			num36.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown36 = this.layerPanel2r;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown36.Minimum = new decimal(numArray);
			this.layerPanel2r.Name = "layerPanel2r";
			this.layerPanel2r.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2r.TabIndex = 27;
			this.layerPanel2r.ValueChanged += new EventHandler(this.xkeezLciuf);
			this.layerPanel2r.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2r.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c2y.Location = new Point(9, 285);
			NumericUpDown num37 = this.layerPanel2c2y;
			numArray = new int[] { 255, 0, 0, 0 };
			num37.Maximum = new decimal(numArray);
			this.layerPanel2c2y.Name = "layerPanel2c2y";
			this.layerPanel2c2y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c2y.TabIndex = 34;
			this.layerPanel2c2y.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c2y.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c2y.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2s.Location = new Point(9, 155);
			NumericUpDown numericUpDown37 = this.layerPanel2s;
			numArray = new int[] { 255, 0, 0, 0 };
			numericUpDown37.Maximum = new decimal(numArray);
			this.layerPanel2s.Name = "layerPanel2s";
			this.layerPanel2s.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2s.TabIndex = 28;
			this.layerPanel2s.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2s.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2s.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c2x.Location = new Point(9, 265);
			NumericUpDown num38 = this.layerPanel2c2x;
			numArray = new int[] { 255, 0, 0, 0 };
			num38.Maximum = new decimal(numArray);
			this.layerPanel2c2x.Name = "layerPanel2c2x";
			this.layerPanel2c2x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c2x.TabIndex = 33;
			this.layerPanel2c2x.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c2x.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c2x.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c1h.Location = new Point(9, 180);
			NumericUpDown numericUpDown38 = this.layerPanel2c1h;
			numArray = new int[] { 90, 0, 0, 0 };
			numericUpDown38.Maximum = new decimal(numArray);
			NumericUpDown num39 = this.layerPanel2c1h;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			num39.Minimum = new decimal(numArray);
			this.layerPanel2c1h.Name = "layerPanel2c1h";
			this.layerPanel2c1h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c1h.TabIndex = 29;
			this.layerPanel2c1h.ValueChanged += new EventHandler(this.layerPanel2c1h_ValueChanged);
			this.layerPanel2c1h.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c1h.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c2h.Location = new Point(9, 245);
			NumericUpDown numericUpDown39 = this.layerPanel2c2h;
			numArray = new int[] { 90, 0, 0, 0 };
			numericUpDown39.Maximum = new decimal(numArray);
			NumericUpDown num40 = this.layerPanel2c2h;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			num40.Minimum = new decimal(numArray);
			this.layerPanel2c2h.Name = "layerPanel2c2h";
			this.layerPanel2c2h.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c2h.TabIndex = 32;
			this.layerPanel2c2h.ValueChanged += new EventHandler(this.layerPanel2c2h_ValueChanged);
			this.layerPanel2c2h.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c2h.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c1x.Location = new Point(9, 200);
			NumericUpDown numericUpDown40 = this.layerPanel2c1x;
			numArray = new int[] { 255, 0, 0, 0 };
			numericUpDown40.Maximum = new decimal(numArray);
			this.layerPanel2c1x.Name = "layerPanel2c1x";
			this.layerPanel2c1x.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c1x.TabIndex = 30;
			this.layerPanel2c1x.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c1x.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c1x.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.layerPanel2c1y.Location = new Point(9, 220);
			NumericUpDown num41 = this.layerPanel2c1y;
			numArray = new int[] { 255, 0, 0, 0 };
			num41.Maximum = new decimal(numArray);
			this.layerPanel2c1y.Name = "layerPanel2c1y";
			this.layerPanel2c1y.Size = new System.Drawing.Size(60, 20);
			this.layerPanel2c1y.TabIndex = 31;
			this.layerPanel2c1y.ValueChanged += new EventHandler(this.layerPanel2c1y_ValueChanged);
			this.layerPanel2c1y.Enter += new EventHandler(this.layerPanel2c1y_Enter);
			this.layerPanel2c1y.Leave += new EventHandler(this.layerPanel2c1y_Leave);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(13, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Layer";
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.lLayersA);
			this.groupBox3.Controls.Add(this.lLayersC);
			this.groupBox3.Controls.Add(this.butReCenter);
			this.groupBox3.Controls.Add(this.refreshAuto);
			this.groupBox3.Controls.Add(this.MirrorButton);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.layerToMirror);
			this.groupBox3.Controls.Add(this.colorFilterLive);
			this.groupBox3.Controls.Add(this.colorFilterButton);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.colorSetToy);
			this.groupBox3.Controls.Add(this.colorSetTox);
			this.groupBox3.Controls.Add(this.colorSetToh);
			this.groupBox3.Controls.Add(this.colorFiltery);
			this.groupBox3.Controls.Add(this.colorFilterx);
			this.groupBox3.Controls.Add(this.colorFilterh);
			this.groupBox3.Controls.Add(this.inputR);
			this.groupBox3.Controls.Add(this.inputSY);
			this.groupBox3.Controls.Add(this.inputSX);
			this.groupBox3.Controls.Add(this.inputY);
			this.groupBox3.Controls.Add(this.inputX);
			this.groupBox3.Controls.Add(this.butRminus);
			this.groupBox3.Controls.Add(this.butRplus);
			this.groupBox3.Controls.Add(this.button_0);
			this.groupBox3.Controls.Add(this.button_1);
			this.groupBox3.Controls.Add(this.button_2);
			this.groupBox3.Controls.Add(this.button_3);
			this.groupBox3.Controls.Add(this.butYminus);
			this.groupBox3.Controls.Add(this.butYplus);
			this.groupBox3.Controls.Add(this.butXminus);
			this.groupBox3.Controls.Add(this.butXplus);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.DyxZieVhnS);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.groupBox1);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Location = new Point(-2, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(362, 497);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Editor";
			this.button4.FlatStyle = FlatStyle.System;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.button4.Location = new Point(273, 98);
			this.button4.Margin = new System.Windows.Forms.Padding(0);
			this.button4.Name = "button4";
			this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button4.Size = new System.Drawing.Size(10, 40);
			this.button4.TabIndex = 92;
			this.button4.Text = "|";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.lLayersA.AutoSize = true;
			this.lLayersA.Location = new Point(325, 35);
			this.lLayersA.Name = "lLayersA";
			this.lLayersA.Size = new System.Drawing.Size(13, 13);
			this.lLayersA.TabIndex = 78;
			this.lLayersA.Text = "0";
			this.lLayersC.AutoSize = true;
			this.lLayersC.Location = new Point(325, 19);
			this.lLayersC.Name = "lLayersC";
			this.lLayersC.Size = new System.Drawing.Size(13, 13);
			this.lLayersC.TabIndex = 77;
			this.lLayersC.Text = "0";
			this.butReCenter.FlatStyle = FlatStyle.System;
			this.butReCenter.Location = new Point(283, 454);
			this.butReCenter.Name = "butReCenter";
			this.butReCenter.Size = new System.Drawing.Size(70, 20);
			this.butReCenter.TabIndex = 76;
			this.butReCenter.Text = "ReGroup";
			this.butReCenter.UseVisualStyleBackColor = true;
			this.butReCenter.Click += new EventHandler(this.butReCenter_Click);
			this.refreshAuto.FlatStyle = FlatStyle.System;
			this.refreshAuto.Location = new Point(283, 474);
			this.refreshAuto.Name = "refreshAuto";
			this.refreshAuto.Size = new System.Drawing.Size(70, 20);
			this.refreshAuto.TabIndex = 75;
			this.refreshAuto.Text = "Refresh ON";
			this.refreshAuto.UseVisualStyleBackColor = true;
			this.refreshAuto.Click += new EventHandler(this.refreshAuto_Click);
			this.MirrorButton.FlatStyle = FlatStyle.System;
			this.MirrorButton.Location = new Point(283, 403);
			this.MirrorButton.Name = "MirrorButton";
			this.MirrorButton.Size = new System.Drawing.Size(70, 20);
			this.MirrorButton.TabIndex = 72;
			this.MirrorButton.Text = "Mirror OFF";
			this.MirrorButton.UseVisualStyleBackColor = true;
			this.MirrorButton.Click += new EventHandler(this.MirrorButton_Click);
			this.label17.AutoSize = true;
			this.label17.Location = new Point(283, 385);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(33, 13);
			this.label17.TabIndex = 71;
			this.label17.Text = "Layer";
			this.layerToMirror.Location = new Point(318, 383);
			NumericUpDown numericUpDown41 = this.layerToMirror;
			numArray = new int[] { 31, 0, 0, 0 };
			numericUpDown41.Maximum = new decimal(numArray);
			NumericUpDown num42 = this.layerToMirror;
			numArray = new int[] { 1, 0, 0, 0 };
			num42.Minimum = new decimal(numArray);
			this.layerToMirror.Name = "layerToMirror";
			this.layerToMirror.Size = new System.Drawing.Size(35, 20);
			this.layerToMirror.TabIndex = 70;
			NumericUpDown numericUpDown42 = this.layerToMirror;
			numArray = new int[] { 1, 0, 0, 0 };
			numericUpDown42.Value = new decimal(numArray);
			this.colorFilterLive.FlatStyle = FlatStyle.System;
			this.colorFilterLive.Location = new Point(318, 333);
			this.colorFilterLive.Name = "colorFilterLive";
			this.colorFilterLive.Size = new System.Drawing.Size(35, 20);
			this.colorFilterLive.TabIndex = 69;
			this.colorFilterLive.Text = "Live";
			this.colorFilterLive.UseVisualStyleBackColor = true;
			this.colorFilterLive.Click += new EventHandler(this.colorFilterLive_Click);
			this.colorFilterButton.FlatStyle = FlatStyle.System;
			this.colorFilterButton.Location = new Point(283, 333);
			this.colorFilterButton.Name = "colorFilterButton";
			this.colorFilterButton.Size = new System.Drawing.Size(35, 20);
			this.colorFilterButton.TabIndex = 68;
			this.colorFilterButton.Text = "Set";
			this.colorFilterButton.UseVisualStyleBackColor = true;
			this.colorFilterButton.Click += new EventHandler(this.colorFilterButton_Click);
			this.label12.AutoSize = true;
			this.label12.Location = new Point(4, 479);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(86, 13);
			this.label12.TabIndex = 91;
			this.label12.Text = "VinylsData folder";
			this.label16.AutoSize = true;
			this.label16.Location = new Point(288, 259);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(61, 13);
			this.label16.TabIndex = 67;
			this.label16.Text = "Set color to";
			this.label15.AutoSize = true;
			this.label15.Location = new Point(292, 174);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(53, 13);
			this.label15.TabIndex = 66;
			this.label15.Text = "Color filter";
			this.colorSetToy.Location = new Point(283, 313);
			NumericUpDown num43 = this.colorSetToy;
			numArray = new int[] { 255, 0, 0, 0 };
			num43.Maximum = new decimal(numArray);
			this.colorSetToy.Name = "colorSetToy";
			this.colorSetToy.Size = new System.Drawing.Size(70, 20);
			this.colorSetToy.TabIndex = 65;
			this.colorSetToy.ValueChanged += new EventHandler(this.colorSetToy_ValueChanged);
			this.colorSetTox.Location = new Point(283, 293);
			NumericUpDown numericUpDown43 = this.colorSetTox;
			numArray = new int[] { 255, 0, 0, 0 };
			numericUpDown43.Maximum = new decimal(numArray);
			this.colorSetTox.Name = "colorSetTox";
			this.colorSetTox.Size = new System.Drawing.Size(70, 20);
			this.colorSetTox.TabIndex = 64;
			this.colorSetTox.ValueChanged += new EventHandler(this.colorSetTox_ValueChanged);
			this.colorSetToh.Location = new Point(283, 273);
			NumericUpDown num44 = this.colorSetToh;
			numArray = new int[] { 90, 0, 0, 0 };
			num44.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown44 = this.colorSetToh;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown44.Minimum = new decimal(numArray);
			this.colorSetToh.Name = "colorSetToh";
			this.colorSetToh.Size = new System.Drawing.Size(70, 20);
			this.colorSetToh.TabIndex = 63;
			this.colorSetToh.ValueChanged += new EventHandler(this.colorSetToh_ValueChanged);
			this.colorFiltery.Location = new Point(283, 228);
			NumericUpDown num45 = this.colorFiltery;
			numArray = new int[] { 255, 0, 0, 0 };
			num45.Maximum = new decimal(numArray);
			this.colorFiltery.Name = "colorFiltery";
			this.colorFiltery.Size = new System.Drawing.Size(70, 20);
			this.colorFiltery.TabIndex = 62;
			this.colorFilterx.Location = new Point(283, 208);
			NumericUpDown numericUpDown45 = this.colorFilterx;
			numArray = new int[] { 255, 0, 0, 0 };
			numericUpDown45.Maximum = new decimal(numArray);
			this.colorFilterx.Name = "colorFilterx";
			this.colorFilterx.Size = new System.Drawing.Size(70, 20);
			this.colorFilterx.TabIndex = 61;
			this.colorFilterh.Location = new Point(283, 188);
			NumericUpDown num46 = this.colorFilterh;
			numArray = new int[] { 90, 0, 0, 0 };
			num46.Maximum = new decimal(numArray);
			NumericUpDown numericUpDown46 = this.colorFilterh;
			numArray = new int[] { 1, 0, 0, -2147483648 };
			numericUpDown46.Minimum = new decimal(numArray);
			this.colorFilterh.Name = "colorFilterh";
			this.colorFilterh.Size = new System.Drawing.Size(70, 20);
			this.colorFilterh.TabIndex = 60;
			this.colorFilterh.ValueChanged += new EventHandler(this.colorFilterh_ValueChanged);
			this.inputR.Location = new Point(323, 143);
			this.inputR.MaxLength = 3;
			this.inputR.Name = "inputR";
			this.inputR.Size = new System.Drawing.Size(30, 20);
			this.inputR.TabIndex = 40;
			this.inputR.Text = "1";
			this.inputSY.Location = new Point(323, 118);
			this.inputSY.MaxLength = 4;
			this.inputSY.Name = "inputSY";
			this.inputSY.Size = new System.Drawing.Size(30, 20);
			this.inputSY.TabIndex = 39;
			this.inputSY.Text = "10";
			this.inputSX.Location = new Point(323, 98);
			this.inputSX.MaxLength = 4;
			this.inputSX.Name = "inputSX";
			this.inputSX.Size = new System.Drawing.Size(30, 20);
			this.inputSX.TabIndex = 38;
			this.inputSX.Text = "10";
			this.inputY.Location = new Point(323, 73);
			this.inputY.MaxLength = 4;
			this.inputY.Name = "inputY";
			this.inputY.Size = new System.Drawing.Size(30, 20);
			this.inputY.TabIndex = 37;
			this.inputY.Text = "10";
			this.inputX.Location = new Point(323, 53);
			this.inputX.MaxLength = 4;
			this.inputX.Name = "inputX";
			this.inputX.Size = new System.Drawing.Size(30, 20);
			this.inputX.TabIndex = 36;
			this.inputX.Text = "10";
			this.butRminus.FlatStyle = FlatStyle.System;
			this.butRminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.butRminus.Location = new Point(303, 143);
			this.butRminus.Margin = new System.Windows.Forms.Padding(0);
			this.butRminus.Name = "butRminus";
			this.butRminus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.butRminus.Size = new System.Drawing.Size(20, 20);
			this.butRminus.TabIndex = 35;
			this.butRminus.Text = "-";
			this.butRminus.UseVisualStyleBackColor = true;
			this.butRminus.Click += new EventHandler(this.butRminus_Click);
			this.butRplus.FlatStyle = FlatStyle.System;
			this.butRplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.butRplus.Location = new Point(283, 143);
			this.butRplus.Margin = new System.Windows.Forms.Padding(0);
			this.butRplus.Name = "butRplus";
			this.butRplus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.butRplus.Size = new System.Drawing.Size(20, 20);
			this.butRplus.TabIndex = 34;
			this.butRplus.Text = "+";
			this.butRplus.UseVisualStyleBackColor = true;
			this.butRplus.Click += new EventHandler(this.butRplus_Click);
			this.button_0.FlatStyle = FlatStyle.System;
			this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.button_0.Location = new Point(303, 118);
			this.button_0.Margin = new System.Windows.Forms.Padding(0);
			this.button_0.Name = "butSYminus";
			this.button_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button_0.Size = new System.Drawing.Size(20, 20);
			this.button_0.TabIndex = 33;
			this.button_0.Text = "-";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += new EventHandler(this.button_0_Click);
			this.button_1.FlatStyle = FlatStyle.System;
			this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.button_1.Location = new Point(283, 118);
			this.button_1.Margin = new System.Windows.Forms.Padding(0);
			this.button_1.Name = "butSYplus";
			this.button_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button_1.Size = new System.Drawing.Size(20, 20);
			this.button_1.TabIndex = 32;
			this.button_1.Text = "+";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += new EventHandler(this.button_1_Click);
			this.button_2.FlatStyle = FlatStyle.System;
			this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.button_2.Location = new Point(303, 98);
			this.button_2.Margin = new System.Windows.Forms.Padding(0);
			this.button_2.Name = "butSXminus";
			this.button_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button_2.Size = new System.Drawing.Size(20, 20);
			this.button_2.TabIndex = 31;
			this.button_2.Text = "-";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += new EventHandler(this.button_2_Click);
			this.button_3.FlatStyle = FlatStyle.System;
			this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.button_3.Location = new Point(283, 98);
			this.button_3.Margin = new System.Windows.Forms.Padding(0);
			this.button_3.Name = "butSXplus";
			this.button_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button_3.Size = new System.Drawing.Size(20, 20);
			this.button_3.TabIndex = 30;
			this.button_3.Text = "+";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += new EventHandler(this.button_3_Click);
			this.butYminus.FlatStyle = FlatStyle.System;
			this.butYminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.butYminus.Location = new Point(303, 73);
			this.butYminus.Margin = new System.Windows.Forms.Padding(0);
			this.butYminus.Name = "butYminus";
			this.butYminus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.butYminus.Size = new System.Drawing.Size(20, 20);
			this.butYminus.TabIndex = 29;
			this.butYminus.Text = "-";
			this.butYminus.UseVisualStyleBackColor = true;
			this.butYminus.Click += new EventHandler(this.butYminus_Click);
			this.butYplus.FlatStyle = FlatStyle.System;
			this.butYplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.butYplus.Location = new Point(283, 73);
			this.butYplus.Margin = new System.Windows.Forms.Padding(0);
			this.butYplus.Name = "butYplus";
			this.butYplus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.butYplus.Size = new System.Drawing.Size(20, 20);
			this.butYplus.TabIndex = 28;
			this.butYplus.Text = "+";
			this.butYplus.UseVisualStyleBackColor = true;
			this.butYplus.Click += new EventHandler(this.butYplus_Click);
			this.butXminus.FlatStyle = FlatStyle.System;
			this.butXminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.butXminus.Location = new Point(303, 53);
			this.butXminus.Margin = new System.Windows.Forms.Padding(0);
			this.butXminus.Name = "butXminus";
			this.butXminus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.butXminus.Size = new System.Drawing.Size(20, 20);
			this.butXminus.TabIndex = 27;
			this.butXminus.Text = "-";
			this.butXminus.UseVisualStyleBackColor = true;
			this.butXminus.Click += new EventHandler(this.butXminus_Click);
			this.butXplus.FlatStyle = FlatStyle.System;
			this.butXplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.butXplus.Location = new Point(283, 53);
			this.butXplus.Margin = new System.Windows.Forms.Padding(0);
			this.butXplus.Name = "butXplus";
			this.butXplus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.butXplus.Size = new System.Drawing.Size(20, 20);
			this.butXplus.TabIndex = 26;
			this.butXplus.Text = "+";
			this.butXplus.UseVisualStyleBackColor = true;
			this.butXplus.Click += new EventHandler(this.butXplus_Click);
			this.label14.AutoSize = true;
			this.label14.Location = new Point(281, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 13);
			this.label14.TabIndex = 25;
			this.label14.Text = "Current";
			this.label13.AutoSize = true;
			this.label13.Location = new Point(281, 35);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 13);
			this.label13.TabIndex = 24;
			this.label13.Text = "Layers";
			this.button6.FlatStyle = FlatStyle.System;
			this.button6.Location = new Point(201, 474);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(69, 20);
			this.button6.TabIndex = 21;
			this.button6.Text = "<<<";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new EventHandler(this.icTyOjsByk);
			this.button1.FlatStyle = FlatStyle.System;
			this.button1.Location = new Point(57, 454);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 20);
			this.button1.TabIndex = 20;
			this.button1.Text = ">>>";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button3.FlatStyle = FlatStyle.System;
			this.button3.Location = new Point(129, 474);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(69, 20);
			this.button3.TabIndex = 15;
			this.button3.Text = "<<<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button2.FlatStyle = FlatStyle.System;
			this.button2.Location = new Point(129, 454);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 20);
			this.button2.TabIndex = 14;
			this.button2.Text = ">>>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.label11.AutoSize = true;
			this.label11.Location = new Point(8, 410);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 12;
			this.label11.Text = "Color 4";
			this.label10.AutoSize = true;
			this.label10.Location = new Point(8, 340);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Color 3";
			this.label9.AutoSize = true;
			this.label9.Location = new Point(8, 275);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "Color 2";
			this.label8.AutoSize = true;
			this.label8.Location = new Point(8, 210);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Color 1";
			this.label7.AutoSize = true;
			this.label7.Location = new Point(14, 165);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Skew";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(9, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Rotate";
			this.label5.AutoSize = true;
			this.label5.Location = new Point(4, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Scale Y";
			this.DyxZieVhnS.AutoSize = true;
			this.DyxZieVhnS.Location = new Point(13, 75);
			this.DyxZieVhnS.Name = "label4";
			this.DyxZieVhnS.Size = new System.Drawing.Size(35, 13);
			this.DyxZieVhnS.TabIndex = 5;
			this.DyxZieVhnS.Text = "Pos Y";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(4, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Scale X";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(13, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Pos X";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new Point(3, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.ScrollAlwaysVisible = true;
			this.listBox1.Size = new System.Drawing.Size(123, 121);
			this.listBox1.TabIndex = 18;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.loadButton.FlatStyle = FlatStyle.System;
			this.loadButton.Location = new Point(129, 31);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(69, 20);
			this.loadButton.TabIndex = 76;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new EventHandler(this.loadButton_Click);
			this.saveButton.FlatStyle = FlatStyle.System;
			this.saveButton.Location = new Point(129, 57);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(69, 20);
			this.saveButton.TabIndex = 77;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new EventHandler(this.saveButton_Click);
			this.label18.AutoSize = true;
			this.label18.Location = new Point(204, 43);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(27, 13);
			this.label18.TabIndex = 78;
			this.label18.Text = "from";
			this.LoadFromLayer.Location = new Point(235, 41);
			NumericUpDown loadFromLayer = this.LoadFromLayer;
			numArray = new int[] { 31, 0, 0, 0 };
			loadFromLayer.Maximum = new decimal(numArray);
			NumericUpDown loadFromLayer1 = this.LoadFromLayer;
			numArray = new int[] { 1, 0, 0, 0 };
			loadFromLayer1.Minimum = new decimal(numArray);
			this.LoadFromLayer.Name = "LoadFromLayer";
			this.LoadFromLayer.Size = new System.Drawing.Size(47, 20);
			this.LoadFromLayer.TabIndex = 79;
			this.LoadFromLayer.TextAlign = HorizontalAlignment.Center;
			NumericUpDown loadFromLayer2 = this.LoadFromLayer;
			numArray = new int[] { 1, 0, 0, 0 };
			loadFromLayer2.Value = new decimal(numArray);
			this.LoadFromLayer.ValueChanged += new EventHandler(this.LoadFromLayer_ValueChanged);
			this.LoadToLayer.Location = new Point(289, 43);
			this.LoadToLayer.Name = "LoadToLayer";
			this.LoadToLayer.Size = new System.Drawing.Size(19, 13);
			this.LoadToLayer.TabIndex = 80;
			this.LoadToLayer.Text = "31";
			this.LoadToLayer.TextAlign = ContentAlignment.TopCenter;
			this.label20.AutoSize = true;
			this.label20.Location = new Point(333, 43);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(16, 13);
			this.label20.TabIndex = 81;
			this.label20.Text = "to";
			this.label21.AutoSize = true;
			this.label21.Location = new Point(204, 65);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(27, 13);
			this.label21.TabIndex = 82;
			this.label21.Text = "from";
			this.SaveFromLayer.Location = new Point(235, 63);
			NumericUpDown saveFromLayer = this.SaveFromLayer;
			numArray = new int[] { 31, 0, 0, 0 };
			saveFromLayer.Maximum = new decimal(numArray);
			NumericUpDown saveFromLayer1 = this.SaveFromLayer;
			numArray = new int[] { 1, 0, 0, 0 };
			saveFromLayer1.Minimum = new decimal(numArray);
			this.SaveFromLayer.Name = "SaveFromLayer";
			this.SaveFromLayer.Size = new System.Drawing.Size(47, 20);
			this.SaveFromLayer.TabIndex = 83;
			this.SaveFromLayer.TextAlign = HorizontalAlignment.Center;
			NumericUpDown saveFromLayer2 = this.SaveFromLayer;
			numArray = new int[] { 1, 0, 0, 0 };
			saveFromLayer2.Value = new decimal(numArray);
			this.SaveToLayer.Location = new Point(283, 63);
			NumericUpDown saveToLayer = this.SaveToLayer;
			numArray = new int[] { 31, 0, 0, 0 };
			saveToLayer.Maximum = new decimal(numArray);
			NumericUpDown saveToLayer1 = this.SaveToLayer;
			numArray = new int[] { 1, 0, 0, 0 };
			saveToLayer1.Minimum = new decimal(numArray);
			this.SaveToLayer.Name = "SaveToLayer";
			this.SaveToLayer.Size = new System.Drawing.Size(47, 20);
			this.SaveToLayer.TabIndex = 84;
			this.SaveToLayer.TextAlign = HorizontalAlignment.Center;
			NumericUpDown saveToLayer2 = this.SaveToLayer;
			numArray = new int[] { 31, 0, 0, 0 };
			saveToLayer2.Value = new decimal(numArray);
			this.label22.AutoSize = true;
			this.label22.Location = new Point(333, 65);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(16, 13);
			this.label22.TabIndex = 85;
			this.label22.Text = "to";
			this.label23.AutoSize = true;
			this.label23.Location = new Point(203, 86);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(33, 13);
			this.label23.TabIndex = 86;
			this.label23.Text = "name";
			this.OeMxuosSgo.Location = new Point(235, 83);
			this.OeMxuosSgo.Name = "saveName";
			this.OeMxuosSgo.Size = new System.Drawing.Size(95, 20);
			this.OeMxuosSgo.TabIndex = 87;
			this.label24.AutoSize = true;
			this.label24.Location = new Point(329, 87);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(26, 13);
			this.label24.TabIndex = 88;
			this.label24.Text = ".svs";
			this.uploadButton.FlatStyle = FlatStyle.System;
			this.uploadButton.Location = new Point(129, 109);
			this.uploadButton.Name = "uploadButton";
			this.uploadButton.Size = new System.Drawing.Size(69, 20);
			this.uploadButton.TabIndex = 89;
			this.uploadButton.Text = "Upload";
			this.uploadButton.UseVisualStyleBackColor = true;
			this.uploadButton.Click += new EventHandler(this.uploadButton_Click);
			this.deleteButton.FlatStyle = FlatStyle.System;
			this.deleteButton.Location = new Point(129, 83);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(69, 20);
			this.deleteButton.TabIndex = 90;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new EventHandler(this.deleteButton_Click);
			this.groupBox4.Controls.Add(this.button_steal);
			this.groupBox4.Controls.Add(this.loadDesc);
			this.groupBox4.Controls.Add(this.label32);
			this.groupBox4.Controls.Add(this.loadAuthor);
			this.groupBox4.Controls.Add(this.dqmheTawJe);
			this.groupBox4.Controls.Add(this.label28);
			this.groupBox4.Controls.Add(this.saveDesc);
			this.groupBox4.Controls.Add(this.playerNameLabel);
			this.groupBox4.Controls.Add(this.refreshFolder);
			this.groupBox4.Controls.Add(this.label27);
			this.groupBox4.Controls.Add(this.saveAuthor);
			this.groupBox4.Controls.Add(this.label25);
			this.groupBox4.Controls.Add(this.button27);
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Controls.Add(this.deleteButton);
			this.groupBox4.Controls.Add(this.uploadButton);
			this.groupBox4.Controls.Add(this.listBox1);
			this.groupBox4.Controls.Add(this.label24);
			this.groupBox4.Controls.Add(this.OeMxuosSgo);
			this.groupBox4.Controls.Add(this.loadButton);
			this.groupBox4.Controls.Add(this.saveButton);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.SaveToLayer);
			this.groupBox4.Controls.Add(this.LoadFromLayer);
			this.groupBox4.Controls.Add(this.SaveFromLayer);
			this.groupBox4.Controls.Add(this.LoadToLayer);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.label26);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Location = new Point(-2, 500);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(362, 176);
			this.groupBox4.TabIndex = 91;
			this.groupBox4.TabStop = false;
			this.loadDesc.AutoSize = true;
			this.loadDesc.Location = new Point(39, 16);
			this.loadDesc.Margin = new System.Windows.Forms.Padding(0);
			this.loadDesc.Name = "loadDesc";
			this.loadDesc.Size = new System.Drawing.Size(10, 13);
			this.loadDesc.TabIndex = 105;
			this.loadDesc.Text = "-";
			this.label32.AutoSize = true;
			this.label32.Location = new Point(4, 16);
			this.label32.Margin = new System.Windows.Forms.Padding(0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(41, 13);
			this.label32.TabIndex = 104;
			this.label32.Text = "Descr.:";
			this.loadAuthor.AutoSize = true;
			this.loadAuthor.Location = new Point(39, 0);
			this.loadAuthor.Margin = new System.Windows.Forms.Padding(0);
			this.loadAuthor.Name = "loadAuthor";
			this.loadAuthor.Size = new System.Drawing.Size(10, 13);
			this.loadAuthor.TabIndex = 103;
			this.loadAuthor.Text = "-";
			this.dqmheTawJe.AutoSize = true;
			this.dqmheTawJe.Location = new Point(4, 0);
			this.dqmheTawJe.Margin = new System.Windows.Forms.Padding(0);
			this.dqmheTawJe.Name = "label30";
			this.dqmheTawJe.Size = new System.Drawing.Size(41, 13);
			this.dqmheTawJe.TabIndex = 102;
			this.dqmheTawJe.Text = "Author:";
			this.label28.AutoSize = true;
			this.label28.Location = new Point(201, 122);
			this.label28.Margin = new System.Windows.Forms.Padding(0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(58, 13);
			this.label28.TabIndex = 101;
			this.label28.Text = "description";
			this.saveDesc.Location = new Point(204, 135);
			this.saveDesc.Name = "saveDesc";
			this.saveDesc.Size = new System.Drawing.Size(149, 20);
			this.saveDesc.TabIndex = 100;
			this.playerNameLabel.AutoSize = true;
			this.playerNameLabel.Location = new Point(238, 26);
			this.playerNameLabel.Name = "playerNameLabel";
			this.playerNameLabel.Size = new System.Drawing.Size(10, 13);
			this.playerNameLabel.TabIndex = 99;
			this.playerNameLabel.Text = "-";
			this.refreshFolder.FlatStyle = FlatStyle.System;
			this.refreshFolder.Location = new Point(88, 33);
			this.refreshFolder.Name = "refreshFolder";
			this.refreshFolder.Size = new System.Drawing.Size(20, 20);
			this.refreshFolder.TabIndex = 98;
			this.refreshFolder.Text = "R";
			this.refreshFolder.UseVisualStyleBackColor = true;
			this.refreshFolder.Click += new EventHandler(this.refreshFolder_Click);
			this.label27.AutoSize = true;
			this.label27.Location = new Point(190, 158);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(169, 13);
			this.label27.TabIndex = 97;
			this.label27.Text = "2017 © berkay2578";
			this.saveAuthor.Location = new Point(235, 103);
			this.saveAuthor.Name = "saveAuthor";
			this.saveAuthor.Size = new System.Drawing.Size(118, 20);
			this.saveAuthor.TabIndex = 95;
			this.label25.AutoSize = true;
			this.label25.Location = new Point(203, 26);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(38, 13);
			this.label25.TabIndex = 94;
			this.label25.Text = "player:";
			this.button27.FlatStyle = FlatStyle.System;
			this.button27.Location = new Point(66, 153);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(60, 19);
			this.button27.TabIndex = 93;
			this.button27.Text = "Local";
			this.button27.UseVisualStyleBackColor = true;
			this.button27.Click += new EventHandler(this.button27_Click);
			this.button5.FlatStyle = FlatStyle.System;
			this.button5.Location = new Point(2, 153);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(60, 19);
			this.button5.TabIndex = 92;
			this.button5.Text = "Shard";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.label26.AutoSize = true;
			this.label26.Location = new Point(201, 106);
			this.label26.Margin = new System.Windows.Forms.Padding(0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(37, 13);
			this.label26.TabIndex = 96;
			this.label26.Text = "author";
			this.button_steal.FlatStyle = FlatStyle.System;
			this.button_steal.Location = new Point(129, 135);
			this.button_steal.Name = "button_steal";
			this.button_steal.Size = new System.Drawing.Size(69, 20);
			this.button_steal.TabIndex = 106;
			this.button_steal.Text = "Steal it!";
			this.button_steal.UseVisualStyleBackColor = true;
			this.button_steal.Click += new EventHandler(this.button_steal_Click);
			this.logger.Location = new Point(366, 14);
			this.logger.Name = "logger";
			this.logger.Size = new System.Drawing.Size(338, 646);
			this.logger.TabIndex = 92;
			this.logger.Text = "";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new System.Drawing.Size(354, 672);
			base.Controls.Add(this.logger);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox3);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			this.Text = "VinylManager © 2017 berkay2578";
			base.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
			base.Load += new EventHandler(this.Form1_Load);
			base.Paint += new PaintEventHandler(this.Form1_Paint);
			((ISupportInitialize)this.layerPanel1).EndInit();
			this.groupBox1.ResumeLayout(false);
			((ISupportInitialize)this.layerPanel1c4y).EndInit();
			((ISupportInitialize)this.layerPanel1c4x).EndInit();
			((ISupportInitialize)this.layerPanel1c4h).EndInit();
			((ISupportInitialize)this.layerPanel1c3y).EndInit();
			((ISupportInitialize)this.layerPanel1c3x).EndInit();
			((ISupportInitialize)this.layerPanel1c3h).EndInit();
			((ISupportInitialize)this.layerPanel1c2y).EndInit();
			((ISupportInitialize)this.layerPanel1c2x).EndInit();
			((ISupportInitialize)this.layerPanel1c2h).EndInit();
			((ISupportInitialize)this.layerPanel1c1y).EndInit();
			((ISupportInitialize)this.layerPanel1c1x).EndInit();
			((ISupportInitialize)this.layerPanel1c1h).EndInit();
			((ISupportInitialize)this.layerPanel1s).EndInit();
			((ISupportInitialize)this.layerPanel1r).EndInit();
			((ISupportInitialize)this.layerPanel1sY).EndInit();
			((ISupportInitialize)this.layerPanel1sX).EndInit();
			((ISupportInitialize)this.layerPanel1Y).EndInit();
			((ISupportInitialize)this.layerPanel1X).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((ISupportInitialize)this.layerPanel3c4y).EndInit();
			((ISupportInitialize)this.layerPanel3).EndInit();
			((ISupportInitialize)this.layerPanel3c4x).EndInit();
			((ISupportInitialize)this.layerPanel3X).EndInit();
			((ISupportInitialize)this.layerPanel3c4h).EndInit();
			((ISupportInitialize)this.layerPanel3Y).EndInit();
			((ISupportInitialize)this.layerPanel3c3y).EndInit();
			((ISupportInitialize)this.layerPanel3sX).EndInit();
			((ISupportInitialize)this.BdsEcsiibb).EndInit();
			((ISupportInitialize)this.layerPanel3sY).EndInit();
			((ISupportInitialize)this.layerPanel3c3h).EndInit();
			((ISupportInitialize)this.layerPanel3r).EndInit();
			((ISupportInitialize)this.layerPanel3c2y).EndInit();
			((ISupportInitialize)this.layerPanel3s).EndInit();
			((ISupportInitialize)this.layerPanel3c2x).EndInit();
			((ISupportInitialize)this.layerPanel3c1h).EndInit();
			((ISupportInitialize)this.layerPanel3c2h).EndInit();
			((ISupportInitialize)this.layerPanel3c1x).EndInit();
			((ISupportInitialize)this.layerPanel3c1y).EndInit();
			((ISupportInitialize)this.layerPanel2c4y).EndInit();
			((ISupportInitialize)this.layerPanel2).EndInit();
			((ISupportInitialize)this.layerPanel2c4x).EndInit();
			((ISupportInitialize)this.layerPanel2X).EndInit();
			((ISupportInitialize)this.layerPanel2c4h).EndInit();
			((ISupportInitialize)this.layerPanel2Y).EndInit();
			((ISupportInitialize)this.layerPanel2c3y).EndInit();
			((ISupportInitialize)this.layerPanel2sX).EndInit();
			((ISupportInitialize)this.layerPanel2c3x).EndInit();
			((ISupportInitialize)this.layerPanel2sY).EndInit();
			((ISupportInitialize)this.layerPanel2c3h).EndInit();
			((ISupportInitialize)this.layerPanel2r).EndInit();
			((ISupportInitialize)this.layerPanel2c2y).EndInit();
			((ISupportInitialize)this.layerPanel2s).EndInit();
			((ISupportInitialize)this.layerPanel2c2x).EndInit();
			((ISupportInitialize)this.layerPanel2c1h).EndInit();
			((ISupportInitialize)this.layerPanel2c2h).EndInit();
			((ISupportInitialize)this.layerPanel2c1x).EndInit();
			((ISupportInitialize)this.layerPanel2c1y).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((ISupportInitialize)this.layerToMirror).EndInit();
			((ISupportInitialize)this.colorSetToy).EndInit();
			((ISupportInitialize)this.colorSetTox).EndInit();
			((ISupportInitialize)this.colorSetToh).EndInit();
			((ISupportInitialize)this.colorFiltery).EndInit();
			((ISupportInitialize)this.colorFilterx).EndInit();
			((ISupportInitialize)this.colorFilterh).EndInit();
			((ISupportInitialize)this.LoadFromLayer).EndInit();
			((ISupportInitialize)this.SaveFromLayer).EndInit();
			((ISupportInitialize)this.SaveToLayer).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		private void layerPanel1_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)this.layerPanel1.Value;
			if (value < 1)
			{
				value = 1;
			}
			if (value > 31)
			{
				value = 31;
			}
			this.layerPanel1.Value = value;
		}

		private void layerPanel1c1h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel1c1h.Value);
			if (num < 0)
			{
				this.layerPanel1c1h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel1c1h.Value = new decimal(0);
			}
			this.bool_6 = true;
		}

		private void layerPanel1c2h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel1c2h.Value);
			if (num < 0)
			{
				this.layerPanel1c2h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel1c2h.Value = new decimal(0);
			}
			this.bool_6 = true;
		}

		private void layerPanel1c3h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel1c3h.Value);
			if (num < 0)
			{
				this.layerPanel1c3h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel1c3h.Value = new decimal(0);
			}
			this.bool_6 = true;
		}

		private void layerPanel1c4h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel1c4h.Value);
			if (num < 0)
			{
				this.layerPanel1c4h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel1c4h.Value = new decimal(0);
			}
			this.bool_6 = true;
		}

		private void layerPanel1r_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel1r.Value);
			if (num < 0)
			{
				this.layerPanel1r.Value = new decimal(255);
			}
			if (num > 255)
			{
				this.layerPanel1r.Value = new decimal(0);
			}
			this.bool_6 = true;
		}

		private void layerPanel1X_Enter(object sender, EventArgs e)
		{
			this.bool_3 = true;
		}

		private void layerPanel1X_Leave(object sender, EventArgs e)
		{
			this.bool_3 = false;
		}

		private void layerPanel2_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)this.layerPanel2.Value;
			if (value < 1)
			{
				value = 1;
			}
			if (value > 31)
			{
				value = 31;
			}
			this.layerPanel2.Value = value;
		}

		private void layerPanel2c1h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel2c1h.Value);
			if (num < 0)
			{
				this.layerPanel2c1h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel2c1h.Value = new decimal(0);
			}
			this.bool_7 = true;
		}

		private void layerPanel2c1y_Enter(object sender, EventArgs e)
		{
			this.bool_4 = true;
		}

		private void layerPanel2c1y_Leave(object sender, EventArgs e)
		{
			this.bool_4 = false;
		}

		private void layerPanel2c1y_ValueChanged(object sender, EventArgs e)
		{
			this.bool_7 = true;
		}

		private void layerPanel2c2h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel2c2h.Value);
			if (num < 0)
			{
				this.layerPanel2c2h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel2c2h.Value = new decimal(0);
			}
			this.bool_7 = true;
		}

		private void layerPanel2c3h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel2c3h.Value);
			if (num < 0)
			{
				this.layerPanel2c3h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel2c3h.Value = new decimal(0);
			}
			this.bool_7 = true;
		}

		private void layerPanel3_ValueChanged(object sender, EventArgs e)
		{
			int value = (int)this.layerPanel3.Value;
			if (value < 1)
			{
				value = 1;
			}
			if (value > 31)
			{
				value = 31;
			}
			this.layerPanel3.Value = value;
		}

		private void layerPanel3c1h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel3c1h.Value);
			if (num < 0)
			{
				this.layerPanel3c1h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel3c1h.Value = new decimal(0);
			}
			this.bool_8 = true;
		}

		private void layerPanel3c1y_Leave(object sender, EventArgs e)
		{
			this.bool_5 = false;
		}

		private void layerPanel3c1y_ValueChanged(object sender, EventArgs e)
		{
			this.bool_8 = true;
		}

		private void layerPanel3c2h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel3c2h.Value);
			if (num < 0)
			{
				this.layerPanel3c2h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel3c2h.Value = new decimal(0);
			}
			this.bool_8 = true;
		}

		private void layerPanel3c3h_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel3c3h.Value);
			if (num < 0)
			{
				this.layerPanel3c3h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel3c3h.Value = new decimal(0);
			}
			this.bool_8 = true;
		}

		private void layerPanel3r_ValueChanged(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel3r.Value);
			if (num < 0)
			{
				this.layerPanel3r.Value = new decimal(255);
			}
			if (num > 255)
			{
				this.layerPanel3r.Value = new decimal(0);
			}
			this.bool_8 = true;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				if (!this.bool_13)
				{
					this.loadAuthor.Text = this.list_0[this.listBox1.SelectedIndex].author;
					this.loadDesc.Text = string.Concat(this.list_0[this.listBox1.SelectedIndex].layer, " lay.; ", this.list_0[this.listBox1.SelectedIndex].description);
					this.LoadFromLayer.Value = new decimal(1);
					this.int_66 = Convert.ToInt32(this.list_0[this.listBox1.SelectedIndex].layer);
					this.LoadToLayer.Text = this.list_0[this.listBox1.SelectedIndex].layer.ToString();
				}
				else
				{
					string str = string.Concat(Directory.GetCurrentDirectory(), "\\VinylsDataNew\\");
					if (!File.Exists(string.Concat(str, this.listBox1.SelectedItem, ".svs")))
					{
						MessageBox.Show("File not found", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.method_21();
						return;
					}
					string str1 = "";
					using (StreamReader streamReader = File.OpenText(string.Concat(str, this.listBox1.SelectedItem, ".svs")))
					{
						string str2 = "";
						while (true)
						{
							string str3 = streamReader.ReadLine();
							str2 = str3;
							if (str3 == null)
							{
								break;
							}
							str1 = string.Concat(str1, str2);
						}
					}
					try
					{
						Class3 class3 = new Class3((int)base.Handle);
						str1 = class3.method_9(class3.method_7(str1), false);
					}
					catch
					{
						MessageBox.Show("Can't read file", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					try
					{
						string[] strArrays = new string[] { "||" };
						string str4 = str1.Split(strArrays, StringSplitOptions.None)[0];
						char[] chrArray = new char[] { '|' };
						string[] strArrays1 = str4.Split(chrArray, StringSplitOptions.None);
						this.loadAuthor.Text = strArrays1[1];
						this.loadDesc.Text = string.Concat(strArrays1[3], " lay.; ", strArrays1[2]);
						this.LoadFromLayer.Value = new decimal(1);
						this.int_66 = Convert.ToInt32(strArrays1[3]);
						this.LoadToLayer.Text = strArrays1[3];
					}
					catch
					{
						MessageBox.Show("Can't read file", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			if (this.bool_13)
			{
				this.method_22();
				return;
			}
			this.method_23(this.list_0[this.listBox1.SelectedIndex].id);
		}

		private void LoadFromLayer_ValueChanged(object sender, EventArgs e)
		{
			if ((int)this.LoadFromLayer.Value + this.int_66 > 31)
			{
				this.LoadFromLayer.Value = 31 - this.int_66 + 1;
			}
			Label loadToLayer = this.LoadToLayer;
			decimal value = (this.LoadFromLayer.Value + this.int_66)--;
			loadToLayer.Text = value.ToString();
		}

		private void method_0()
		{
			bool flag = true;
			TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
			while (flag)
			{
				this.method_4();
				this.int_11 = this.class1_0.method_13((IntPtr)(this.int_1 + this.int_0));
				this.int_12 = this.class1_0.method_13((IntPtr)(this.int_2 + this.int_0));
				if (this.int_11 != 0)
				{
					this.bool_0 = true;
				}
				else
				{
					this.bool_0 = false;
				}
				if (this.bool_0 != this.bool_1)
				{
					base.Invalidate();
					this.bool_1 = this.bool_0;
				}
				if (!this.bool_0)
				{
					this.int_63 = 0;
					this.int_64 = 0;
				}
				else
				{
					this.int_7 = this.class1_0.method_13((IntPtr)(this.int_11 + 528));
					this.int_8 = this.int_7 + this.int_10;
					this.class1_0.method_20((IntPtr)(this.int_11 + 6 + this.int_9 + 1612), 0);
					this.int_63 = this.class1_0.method_11((IntPtr)(this.int_11 + 5 + this.int_9 + 1612)) + 1;
					this.int_64 = this.class1_0.method_11((IntPtr)(this.int_11 + 4 + this.int_9 + 1612));
					this.int_65 = this.class1_0.method_13((IntPtr)(this.int_11 + this.int_9 + 1612));
					this.string_5 = this.class1_0.method_9((IntPtr)(this.int_12 + 137), 14);
					base.Invoke(this.delegate7_0);
					if (!this.GetBit(this.int_65, Convert.ToInt32(this.layerToMirror.Value)))
					{
						this.bool_12 = false;
						base.Invoke(this.delegate6_0);
					}
					else
					{
						this.bool_12 = true;
						base.Invoke(this.delegate6_0);
					}
					if (this.bool_11)
					{
						if (!this.bool_3)
						{
							try
							{
								this.method_1(Convert.ToInt32(this.layerPanel1.Value));
								base.Invoke(this.delegate2_0);
							}
							catch
							{
							}
						}
						if (!this.bool_4)
						{
							try
							{
								this.method_1(Convert.ToInt32(this.layerPanel2.Value));
								base.Invoke(this.delegate3_0);
							}
							catch
							{
							}
						}
						if (!this.bool_5)
						{
							try
							{
								this.method_1(Convert.ToInt32(this.layerPanel3.Value));
								base.Invoke(this.delegate4_0);
							}
							catch
							{
							}
						}
					}
					if (this.bool_6 && this.bool_3)
					{
						this.method_5();
						this.method_2(Convert.ToInt32(this.layerPanel1.Value));
						this.method_3();
						this.bool_6 = false;
					}
					if (this.bool_7 && this.bool_4)
					{
						this.method_6();
						this.method_2(Convert.ToInt32(this.layerPanel2.Value));
						this.method_3();
						this.bool_7 = false;
					}
					if (this.bool_8 && this.bool_5)
					{
						this.method_7();
						this.method_2(Convert.ToInt32(this.layerPanel3.Value));
						this.method_3();
						this.bool_8 = false;
					}
				}
				base.Invoke(this.delegate5_0);
				Thread.Sleep(100);
			}
		}

		private void method_1(int int_67)
		{
			if (this.bool_0)
			{
				int num = 0;
				bool flag = false;
				this.int_17 = this.class1_0.method_12((IntPtr)(this.int_11 + 36 + this.int_9 + (int_67 - 1) * 52));
				this.int_18 = this.class1_0.method_12((IntPtr)(this.int_11 + 38 + this.int_9 + (int_67 - 1) * 52));
				this.int_19 = this.class1_0.method_12((IntPtr)(this.int_11 + 40 + this.int_9 + (int_67 - 1) * 52));
				this.int_20 = this.class1_0.method_12((IntPtr)(this.int_11 + 42 + this.int_9 + (int_67 - 1) * 52));
				this.int_21 = this.class1_0.method_11((IntPtr)(this.int_11 + 44 + this.int_9 + (int_67 - 1) * 52));
				this.int_22 = this.class1_0.method_11((IntPtr)(this.int_11 + 45 + this.int_9 + (int_67 - 1) * 52));
				num = this.class1_0.method_13((IntPtr)(this.int_11 + 4 + this.int_9 + (int_67 - 1) * 52));
				if (num != 0)
				{
					this.int_23 = (num - this.int_7) / 12;
				}
				else
				{
					this.class1_0.method_22((IntPtr)(this.int_11 + 4 + this.int_9 + (int_67 - 1) * 52), this.int_7);
					this.int_23 = 0;
					flag = true;
				}
				this.int_24 = this.class1_0.method_11((IntPtr)(this.int_11 + 8 + this.int_9 + (int_67 - 1) * 52));
				this.int_25 = this.class1_0.method_11((IntPtr)(this.int_11 + 9 + this.int_9 + (int_67 - 1) * 52));
				num = this.class1_0.method_13((IntPtr)(this.int_11 + 12 + this.int_9 + (int_67 - 1) * 52));
				if (num != 0)
				{
					this.int_26 = (num - this.int_7) / 12;
				}
				else
				{
					this.class1_0.method_22((IntPtr)(this.int_11 + 12 + this.int_9 + (int_67 - 1) * 52), this.int_7);
					this.int_26 = 0;
					flag = true;
				}
				this.int_27 = this.class1_0.method_11((IntPtr)(this.int_11 + 16 + this.int_9 + (int_67 - 1) * 52));
				this.int_28 = this.class1_0.method_11((IntPtr)(this.int_11 + 17 + this.int_9 + (int_67 - 1) * 52));
				num = this.class1_0.method_13((IntPtr)(this.int_11 + 20 + this.int_9 + (int_67 - 1) * 52));
				if (num != 0)
				{
					this.int_29 = (num - this.int_7) / 12;
				}
				else
				{
					this.class1_0.method_22((IntPtr)(this.int_11 + 20 + this.int_9 + (int_67 - 1) * 52), this.int_7);
					this.int_29 = 0;
					flag = true;
				}
				this.int_30 = this.class1_0.method_11((IntPtr)(this.int_11 + 24 + this.int_9 + (int_67 - 1) * 52));
				this.int_31 = this.class1_0.method_11((IntPtr)(this.int_11 + 25 + this.int_9 + (int_67 - 1) * 52));
				num = this.class1_0.method_13((IntPtr)(this.int_11 + 28 + this.int_9 + (int_67 - 1) * 52));
				if (num != 0)
				{
					this.int_32 = (num - this.int_7) / 12;
				}
				else
				{
					this.class1_0.method_22((IntPtr)(this.int_11 + 28 + this.int_9 + (int_67 - 1) * 52), this.int_7);
					this.int_32 = 0;
					flag = true;
				}
				this.int_33 = this.class1_0.method_11((IntPtr)(this.int_11 + 32 + this.int_9 + (int_67 - 1) * 52));
				this.int_34 = this.class1_0.method_11((IntPtr)(this.int_11 + 33 + this.int_9 + (int_67 - 1) * 52));
				if (flag)
				{
					this.method_3();
				}
			}
		}

		private void method_10()
		{
			if (this.bool_12)
			{
				this.MirrorButton.Text = "Mirror ON";
				return;
			}
			this.MirrorButton.Text = "Mirror OFF";
		}

		private void method_11()
		{
			this.layerPanel1X.Value = this.int_17;
			this.layerPanel1Y.Value = this.int_18;
			this.layerPanel1sX.Value = this.int_19;
			this.layerPanel1sY.Value = this.int_20;
			this.layerPanel1r.Value = this.int_21;
			this.layerPanel1s.Value = this.int_22;
			this.layerPanel1c1h.Value = this.int_23;
			this.layerPanel1c1x.Value = this.int_24;
			this.layerPanel1c1y.Value = this.int_25;
			this.layerPanel1c2h.Value = this.int_26;
			this.layerPanel1c2x.Value = this.int_27;
			this.layerPanel1c2y.Value = this.int_28;
			this.layerPanel1c3h.Value = this.int_29;
			this.layerPanel1c3x.Value = this.int_30;
			this.layerPanel1c3y.Value = this.int_31;
			this.layerPanel1c4h.Value = this.int_32;
			this.layerPanel1c4x.Value = this.int_33;
			this.layerPanel1c4y.Value = this.int_34;
		}

		private void method_12()
		{
			this.layerPanel2X.Value = this.int_17;
			this.layerPanel2Y.Value = this.int_18;
			this.layerPanel2sX.Value = this.int_19;
			this.layerPanel2sY.Value = this.int_20;
			this.layerPanel2r.Value = this.int_21;
			this.layerPanel2s.Value = this.int_22;
			this.layerPanel2c1h.Value = this.int_23;
			this.layerPanel2c1x.Value = this.int_24;
			this.layerPanel2c1y.Value = this.int_25;
			this.layerPanel2c2h.Value = this.int_26;
			this.layerPanel2c2x.Value = this.int_27;
			this.layerPanel2c2y.Value = this.int_28;
			this.layerPanel2c3h.Value = this.int_29;
			this.layerPanel2c3x.Value = this.int_30;
			this.layerPanel2c3y.Value = this.int_31;
			this.layerPanel2c4h.Value = this.int_32;
			this.layerPanel2c4x.Value = this.int_33;
			this.layerPanel2c4y.Value = this.int_34;
		}

		private void method_13()
		{
			this.layerPanel3X.Value = this.int_17;
			this.layerPanel3Y.Value = this.int_18;
			this.layerPanel3sX.Value = this.int_19;
			this.layerPanel3sY.Value = this.int_20;
			this.layerPanel3r.Value = this.int_21;
			this.layerPanel3s.Value = this.int_22;
			this.layerPanel3c1h.Value = this.int_23;
			this.layerPanel3c1x.Value = this.int_24;
			this.layerPanel3c1y.Value = this.int_25;
			this.layerPanel3c2h.Value = this.int_26;
			this.layerPanel3c2x.Value = this.int_27;
			this.layerPanel3c2y.Value = this.int_28;
			this.layerPanel3c3h.Value = this.int_29;
			this.BdsEcsiibb.Value = this.int_30;
			this.layerPanel3c3y.Value = this.int_31;
			this.layerPanel3c4h.Value = this.int_32;
			this.layerPanel3c4x.Value = this.int_33;
			this.layerPanel3c4y.Value = this.int_34;
		}

		private void method_14()
		{
			this.lLayersC.Text = this.int_63.ToString();
			this.lLayersA.Text = this.int_64.ToString();
		}

		private void method_15()
		{
			Process.GetCurrentProcess().Kill();
			Application.Exit();
		}

		private void method_16(int int_67, int int_68)
		{
			if (this.bool_0)
			{
				int value = (int)this.layerPanel2.Value;
				int num = (int)this.layerPanel3.Value;
				if (num < value)
				{
					value = (int)this.layerPanel3.Value;
					num = (int)this.layerPanel2.Value;
				}
				for (int i = value; i <= num; i++)
				{
					short num1 = this.class1_0.method_12((IntPtr)(this.int_11 + 36 + this.int_9 + (i - 1) * 52));
					short num2 = this.class1_0.method_12((IntPtr)(this.int_11 + 38 + this.int_9 + (i - 1) * 52));
					this.class1_0.method_21((IntPtr)(this.int_11 + 36 + this.int_9 + (i - 1) * 52), (short)(num1 + int_67));
					this.class1_0.method_21((IntPtr)(this.int_11 + 38 + this.int_9 + (i - 1) * 52), (short)(num2 + int_68));
					this.int_53[i] += int_67;
					this.int_54[i] += int_68;
					this.double_2 += (double)int_67;
					this.double_3 += (double)int_68;
				}
				this.method_3();
			}
		}

		private void method_17(int int_67, int int_68)
		{
			if (this.bool_0)
			{
				int value = (int)this.layerPanel2.Value;
				int num = (int)this.layerPanel3.Value;
				if (num < value)
				{
					value = (int)this.layerPanel3.Value;
					num = (int)this.layerPanel2.Value;
				}
				if (this.int_57 != value || this.int_58 != num || this.int_16 != 2)
				{
					this.int_57 = value;
					this.int_58 = num;
					this.double_2 = 0;
					this.double_3 = 0;
					for (int i = value; i <= num; i++)
					{
						short num1 = this.class1_0.method_12((IntPtr)(this.int_11 + 36 + this.int_9 + (i - 1) * 52));
						short num2 = this.class1_0.method_12((IntPtr)(this.int_11 + 38 + this.int_9 + (i - 1) * 52));
						this.int_55[i] = this.class1_0.method_12((IntPtr)(this.int_11 + 40 + this.int_9 + (i - 1) * 52));
						this.int_56[i] = this.class1_0.method_12((IntPtr)(this.int_11 + 42 + this.int_9 + (i - 1) * 52));
						this.int_53[i] = num1;
						this.int_54[i] = num2;
						this.double_2 += (double)num1;
						this.double_3 += (double)num2;
					}
					this.double_2 /= (double)(num - value + 1);
					this.double_3 /= (double)(num - value + 1);
					this.int_60 = 100;
					this.int_61 = 100;
				}
				this.int_60 += int_67;
				this.int_61 += int_68;
				if (this.int_60 < 0)
				{
					this.int_60 = 0;
				}
				if (this.int_61 < 0)
				{
					this.int_61 = 0;
				}
				for (int j = value; j <= num; j++)
				{
					if (this.int_60 == 0)
					{
						this.class1_0.method_21((IntPtr)(this.int_11 + 36 + this.int_9 + (j - 1) * 52), (short)this.double_2);
						this.class1_0.method_21((IntPtr)(this.int_11 + 40 + this.int_9 + (j - 1) * 52), 1);
					}
					else
					{
						this.class1_0.method_21((IntPtr)(this.int_11 + 36 + this.int_9 + (j - 1) * 52), (short)((double)this.int_53[j] - ((double)this.int_53[j] - this.double_2) * (double)(100 - this.int_60) / 100));
						this.class1_0.method_21((IntPtr)(this.int_11 + 40 + this.int_9 + (j - 1) * 52), (short)(this.int_60 * this.int_55[j] / 100));
					}
					if (this.int_61 == 0)
					{
						this.class1_0.method_21((IntPtr)(this.int_11 + 38 + this.int_9 + (j - 1) * 52), (short)this.double_3);
						this.class1_0.method_21((IntPtr)(this.int_11 + 42 + this.int_9 + (j - 1) * 52), 1);
					}
					else
					{
						this.class1_0.method_21((IntPtr)(this.int_11 + 38 + this.int_9 + (j - 1) * 52), (short)((double)this.int_54[j] - ((double)this.int_54[j] - this.double_3) * (double)(100 - this.int_61) / 100));
						this.class1_0.method_21((IntPtr)(this.int_11 + 42 + this.int_9 + (j - 1) * 52), (short)(this.int_61 * this.int_56[j] / 100));
					}
				}
				this.int_16 = 2;
				this.method_3();
			}
		}

		private void method_18(int int_67)
		{
			double double3;
			double double2;
			if (this.bool_0)
			{
				int value = (int)this.layerPanel2.Value;
				int num = (int)this.layerPanel3.Value;
				if (num < value)
				{
					value = (int)this.layerPanel3.Value;
					num = (int)this.layerPanel2.Value;
				}
				if (this.int_57 != value || this.int_58 != num || this.int_16 != 1)
				{
					this.int_57 = value;
					this.int_58 = num;
					this.double_2 = 0;
					this.double_3 = 0;
					for (int i = value; i <= num; i++)
					{
						short num1 = this.class1_0.method_12((IntPtr)(this.int_11 + 36 + this.int_9 + (i - 1) * 52));
						short num2 = this.class1_0.method_12((IntPtr)(this.int_11 + 38 + this.int_9 + (i - 1) * 52));
						this.double_2 += (double)num1;
						this.double_3 += (double)num2;
						this.int_53[i] = num1;
						this.int_54[i] = num2;
						this.double_1[i, 1] = (double)this.class1_0.method_11((IntPtr)(this.int_11 + 44 + this.int_9 + (i - 1) * 52));
					}
					this.double_2 /= (double)(num - value + 1);
					this.double_3 /= (double)(num - value + 1);
					for (int j = value; j <= num; j++)
					{
						double2 = this.double_2 - (double)this.int_53[j];
						double3 = this.double_3 - (double)this.int_54[j];
						this.double_0[j, 0] = Math.Sqrt(double2 * double2 + double3 * double3);
						if ((double2 < 0 || double3 <= 0) && (double2 <= 0 || double3 > 0))
						{
							this.double_0[j, 1] = -1;
						}
						else
						{
							this.double_0[j, 1] = 1;
						}
						if (double2 != 0 && double3 != 0)
						{
							this.double_1[j, 0] = Math.Atan(double3 / double2) * 180 / 3.14159265358979;
						}
						else if (double2 == 0)
						{
							this.double_1[j, 0] = 90;
						}
						else
						{
							this.double_1[j, 0] = 0;
						}
					}
					this.int_59 = 0;
				}
				this.int_59 += int_67;
				if (this.int_59 > 359)
				{
					this.int_59 -= 360;
				}
				if (this.int_59 < 0)
				{
					this.int_59 += 360;
				}
				for (int k = value; k <= num; k++)
				{
					double2 = this.double_0[k, 0] * Math.Cos(((double)this.int_59 + this.double_1[k, 0]) * 3.14159265358979 / 180) * this.double_0[k, 1];
					double3 = this.double_0[k, 0] * Math.Sin(((double)this.int_59 + this.double_1[k, 0]) * 3.14159265358979 / 180) * this.double_0[k, 1];
					this.class1_0.method_21((IntPtr)(this.int_11 + 36 + this.int_9 + (k - 1) * 52), (short)(this.double_2 - double2));
					this.class1_0.method_21((IntPtr)(this.int_11 + 38 + this.int_9 + (k - 1) * 52), (short)(this.double_3 - double3));
					this.class1_0.method_20((IntPtr)(this.int_11 + 44 + this.int_9 + (k - 1) * 52), (byte)(this.double_1[k, 1] + Math.Round((double)this.int_59 * 255 / 360, 0)));
				}
				this.int_16 = 1;
				this.method_3();
			}
		}

		private void method_19()
		{
			if (this.bool_0)
			{
				int value = (int)this.layerPanel2.Value;
				int num = (int)this.layerPanel3.Value;
				if (num < value)
				{
					value = (int)this.layerPanel3.Value;
					num = (int)this.layerPanel2.Value;
				}
				byte num1 = Convert.ToByte(this.colorFilterh.Value);
				byte num2 = Convert.ToByte(this.colorFilterx.Value);
				byte num3 = Convert.ToByte(this.colorFiltery.Value);
				if (this.int_62 != num1 || this.byte_1 != num2 || this.byte_2 != num3)
				{
					this.int_62 = num1;
					this.byte_1 = num2;
					this.byte_2 = num3;
					for (int i = value; i <= num; i++)
					{
						for (int j = 0; j < 4; j++)
						{
							byte num4 = (byte)((this.class1_0.method_13((IntPtr)(this.int_11 + 4 + 8 * j + this.int_9 + (i - 1) * 52)) - this.int_7) / 12);
							byte num5 = this.class1_0.method_11((IntPtr)(this.int_11 + 8 + 8 * j + this.int_9 + (i - 1) * 52));
							byte num6 = this.class1_0.method_11((IntPtr)(this.int_11 + 9 + 8 * j + this.int_9 + (i - 1) * 52));
							if (num4 != num1 || num5 != num2 || num6 != num3)
							{
								this.byte_0[i, j] = 0;
							}
							else
							{
								this.byte_0[i, j] = 1;
							}
						}
					}
				}
				num1 = Convert.ToByte(this.colorSetToh.Value);
				num2 = Convert.ToByte(this.colorSetTox.Value);
				num3 = Convert.ToByte(this.colorSetToy.Value);
				for (int k = value; k <= num; k++)
				{
					for (int l = 0; l < 4; l++)
					{
						if (this.byte_0[k, l] == 1)
						{
							this.class1_0.method_22((IntPtr)(this.int_11 + 4 + 8 * l + this.int_9 + (k - 1) * 52), num1 * 12 + this.int_7);
							this.class1_0.method_20((IntPtr)(this.int_11 + 8 + 8 * l + this.int_9 + (k - 1) * 52), num2);
							this.class1_0.method_20((IntPtr)(this.int_11 + 9 + 8 * l + this.int_9 + (k - 1) * 52), num3);
						}
					}
				}
				this.method_3();
			}
		}

		private void method_2(int int_67)
		{
			if (this.bool_0)
			{
				try
				{
					this.class1_0.method_21((IntPtr)(this.int_11 + 36 + this.int_9 + (int_67 - 1) * 52), Convert.ToInt16(this.int_35));
					this.class1_0.method_21((IntPtr)(this.int_11 + 38 + this.int_9 + (int_67 - 1) * 52), Convert.ToInt16(this.int_36));
					this.class1_0.method_21((IntPtr)(this.int_11 + 40 + this.int_9 + (int_67 - 1) * 52), Convert.ToInt16(this.int_37));
					this.class1_0.method_21((IntPtr)(this.int_11 + 42 + this.int_9 + (int_67 - 1) * 52), Convert.ToInt16(this.int_38));
					this.class1_0.method_20((IntPtr)(this.int_11 + 44 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_39));
					this.class1_0.method_20((IntPtr)(this.int_11 + 45 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_40));
					this.class1_0.method_22((IntPtr)(this.int_11 + 4 + this.int_9 + (int_67 - 1) * 52), this.int_41 * 12 + this.int_7);
					this.class1_0.method_20((IntPtr)(this.int_11 + 8 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_42));
					this.class1_0.method_20((IntPtr)(this.int_11 + 9 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_43));
					this.class1_0.method_22((IntPtr)(this.int_11 + 12 + this.int_9 + (int_67 - 1) * 52), this.int_44 * 12 + this.int_7);
					this.class1_0.method_20((IntPtr)(this.int_11 + 16 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_45));
					this.class1_0.method_20((IntPtr)(this.int_11 + 17 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_46));
					this.class1_0.method_22((IntPtr)(this.int_11 + 20 + this.int_9 + (int_67 - 1) * 52), this.int_47 * 12 + this.int_7);
					this.class1_0.method_20((IntPtr)(this.int_11 + 24 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_48));
					this.class1_0.method_20((IntPtr)(this.int_11 + 25 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_49));
					this.class1_0.method_22((IntPtr)(this.int_11 + 28 + this.int_9 + (int_67 - 1) * 52), this.int_50 * 12 + this.int_7);
					this.class1_0.method_20((IntPtr)(this.int_11 + 32 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_51));
					this.class1_0.method_20((IntPtr)(this.int_11 + 33 + this.int_9 + (int_67 - 1) * 52), Convert.ToByte(this.int_52));
				}
				catch
				{
				}
			}
		}

		private void method_20()
		{
			if (this.bool_0)
			{
				if (this.int_64 == 0)
				{
					MessageBox.Show("Can't save vinyl, no layers to save", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					int num = this.class1_0.method_13((IntPtr)(this.int_11 + this.int_9 + 1612));
					string str = "";
					int value = (int)this.SaveFromLayer.Value;
					int int64 = (int)this.SaveToLayer.Value;
					if (int64 < value)
					{
						value = (int)this.SaveToLayer.Value;
						int64 = (int)this.SaveFromLayer.Value;
					}
					if (int64 > this.int_64)
					{
						int64 = this.int_64;
					}
					if (this.saveAuthor.Text == "")
					{
						this.saveAuthor.Text = this.playerNameLabel.Text;
					}
					if (this.saveDesc.Text == "")
					{
						this.saveDesc.Text = "No description";
					}
					object[] text = new object[] { this.playerNameLabel.Text, "|", this.saveAuthor.Text, "|", this.saveDesc.Text, "|", int64, "||" };
					str = string.Concat(text);
					for (int i = value; i <= int64; i++)
					{
						int int8 = this.class1_0.method_13((IntPtr)(this.int_11 + this.int_9 + (i - 1) * 52));
						if (int8 == 0)
						{
							int64 = i;
						}
						else
						{
							int8 -= this.int_8;
							int num1 = this.class1_0.method_12((IntPtr)(this.int_11 + 36 + this.int_9 + (i - 1) * 52));
							int num2 = this.class1_0.method_12((IntPtr)(this.int_11 + 38 + this.int_9 + (i - 1) * 52));
							int num3 = this.class1_0.method_12((IntPtr)(this.int_11 + 40 + this.int_9 + (i - 1) * 52));
							int num4 = this.class1_0.method_12((IntPtr)(this.int_11 + 42 + this.int_9 + (i - 1) * 52));
							int num5 = this.class1_0.method_11((IntPtr)(this.int_11 + 44 + this.int_9 + (i - 1) * 52));
							int num6 = this.class1_0.method_11((IntPtr)(this.int_11 + 45 + this.int_9 + (i - 1) * 52));
							int int7 = this.class1_0.method_13((IntPtr)(this.int_11 + 4 + this.int_9 + (i - 1) * 52));
							if (int7 != 0)
							{
								int7 = (int7 - this.int_7) / 12;
							}
							int num7 = this.class1_0.method_11((IntPtr)(this.int_11 + 8 + this.int_9 + (i - 1) * 52));
							int num8 = this.class1_0.method_11((IntPtr)(this.int_11 + 9 + this.int_9 + (i - 1) * 52));
							int int71 = this.class1_0.method_13((IntPtr)(this.int_11 + 12 + this.int_9 + (i - 1) * 52));
							if (int71 != 0)
							{
								int71 = (int71 - this.int_7) / 12;
							}
							int num9 = this.class1_0.method_11((IntPtr)(this.int_11 + 16 + this.int_9 + (i - 1) * 52));
							int num10 = this.class1_0.method_11((IntPtr)(this.int_11 + 17 + this.int_9 + (i - 1) * 52));
							int int72 = this.class1_0.method_13((IntPtr)(this.int_11 + 20 + this.int_9 + (i - 1) * 52));
							if (int72 != 0)
							{
								int72 = (int72 - this.int_7) / 12;
							}
							int num11 = this.class1_0.method_11((IntPtr)(this.int_11 + 24 + this.int_9 + (i - 1) * 52));
							int num12 = this.class1_0.method_11((IntPtr)(this.int_11 + 25 + this.int_9 + (i - 1) * 52));
							int int73 = this.class1_0.method_13((IntPtr)(this.int_11 + 28 + this.int_9 + (i - 1) * 52));
							if (int73 != 0)
							{
								int73 = (int73 - this.int_7) / 12;
							}
							int num13 = this.class1_0.method_11((IntPtr)(this.int_11 + 32 + this.int_9 + (i - 1) * 52));
							int num14 = this.class1_0.method_11((IntPtr)(this.int_11 + 33 + this.int_9 + (i - 1) * 52));
							int num15 = Convert.ToInt32(this.GetBit(num, i));
							object[] objArray = new object[] { str, int8, "|", num15, "|", num1, "|", num2, "|", num3, "|", num4, "|", num5, "|", num6, "|", int7, "|", num7, "|", num8, "|", int71, "|", num9, "|", num10, "|", int72, "|", num11, "|", num12, "|", int73, "|", num13, "|", num14, "||" };
							str = string.Concat(objArray);
						}
					}
					str = string.Concat(str, "-1");
					if (this.OeMxuosSgo.Text == "")
					{
						this.OeMxuosSgo.Text = "NoName";
					}
					string text1 = this.OeMxuosSgo.Text;
					string str1 = string.Concat(Directory.GetCurrentDirectory(), "\\VinylsDataNew\\");
					while (File.Exists(string.Concat(str1, text1, ".svs")))
					{
						text1 = string.Concat(text1, "+");
					}
					Class3 class3 = new Class3((int)base.Handle);
					str = class3.method_6(class3.method_9(str, true));
					try
					{
						using (FileStream fileStream = File.Create(string.Concat(str1, text1, ".svs")))
						{
							byte[] bytes = (new UTF8Encoding(true)).GetBytes(str);
							fileStream.Write(bytes, 0, (int)bytes.Length);
						}
						this.listBox1.Items.Add(text1);
						MessageBox.Show(string.Concat("Vinyl was save with name \"", this.OeMxuosSgo.Text, "\""), "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					catch
					{
						MessageBox.Show("Can't save vinyl", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
		}

		private void method_21()
		{
			this.listBox1.Items.Clear();
			string str = string.Concat(Directory.GetCurrentDirectory(), "\\VinylsDataNew");
			if (!Directory.Exists(str))
			{
				Directory.CreateDirectory(str);
			}
			foreach (string str1 in Directory.EnumerateFiles(str, "*.svs"))
			{
				string str2 = "";
				str2 = str1.Substring(str.Length + 1);
				str2 = str2.Substring(0, str2.Length - 4);
				this.listBox1.Items.Add(str2);
			}
		}

		private void method_22()
		{
			if (this.bool_0)
			{
				if (this.listBox1.SelectedIndex != -1)
				{
					string str = string.Concat(Directory.GetCurrentDirectory(), "\\VinylsDataNew\\");
					if (!File.Exists(string.Concat(str, this.listBox1.SelectedItem, ".svs")))
					{
						MessageBox.Show("File Not Found", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						this.method_21();
						return;
					}
					string str1 = "";
					using (StreamReader streamReader = File.OpenText(string.Concat(str, this.listBox1.SelectedItem, ".svs")))
					{
						string str2 = "";
						while (true)
						{
							string str3 = streamReader.ReadLine();
							str2 = str3;
							if (str3 == null)
							{
								break;
							}
							str1 = string.Concat(str1, str2);
						}
					}
					this.method_24(str1);
					return;
				}
				MessageBox.Show("File not selected", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void method_23(int int_67)
		{
			MessageBox.Show("No server to communicate...", "Jebaited", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void method_24(string string_10)
		{
			try
			{
				Class3 class3 = new Class3((int)base.Handle);
				string_10 = class3.method_9(class3.method_7(string_10), false);
			}
			catch
			{
				MessageBox.Show("Can't read file", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			try
			{
				string[] strArrays = new string[] { "||" };
				string[] strArrays1 = string_10.Split(strArrays, StringSplitOptions.None);
				string str = strArrays1[0];
				char[] chrArray = new char[] { '|' };
				string[] strArrays2 = str.Split(chrArray, StringSplitOptions.None);
				bool flag = true;
				string[] string4 = this.string_4;
				int num = 0;
				while (true)
				{
					if (num < (int)string4.Length)
					{
						string str1 = string4[num];
						if (strArrays2[0].ToLower().Contains(str1.ToLower()))
						{
							flag = false;
							break;
						}
						else
						{
							num++;
						}
					}
					else
					{
						break;
					}
				}
				if (flag)
				{
					int num1 = 1;
					int num2 = this.class1_0.method_13((IntPtr)(this.int_11 + this.int_9 + 1612));
					for (int i = (int)this.LoadFromLayer.Value; i <= Convert.ToInt32(this.LoadToLayer.Text); i++)
					{
						string str2 = strArrays1[num1];
						char[] chrArray1 = new char[] { '|' };
						string[] strArrays3 = str2.Split(chrArray1, StringSplitOptions.None);
						num1++;
						this.class1_0.method_22((IntPtr)(this.int_11 + this.int_9 + (i - 1) * 52), Convert.ToInt32(strArrays3[0]) + this.int_8);
						num2 = this.SetBit(num2, i, Convert.ToBoolean(Convert.ToByte(strArrays3[1])));
						this.class1_0.method_21((IntPtr)(this.int_11 + 36 + this.int_9 + (i - 1) * 52), Convert.ToInt16(strArrays3[2]));
						this.class1_0.method_21((IntPtr)(this.int_11 + 38 + this.int_9 + (i - 1) * 52), Convert.ToInt16(strArrays3[3]));
						this.class1_0.method_21((IntPtr)(this.int_11 + 40 + this.int_9 + (i - 1) * 52), Convert.ToInt16(strArrays3[4]));
						this.class1_0.method_21((IntPtr)(this.int_11 + 42 + this.int_9 + (i - 1) * 52), Convert.ToInt16(strArrays3[5]));
						this.class1_0.method_20((IntPtr)(this.int_11 + 44 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[6]));
						this.class1_0.method_20((IntPtr)(this.int_11 + 45 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[7]));
						int num3 = Convert.ToInt32(strArrays3[8]);
						if (num3 != 0)
						{
							this.class1_0.method_22((IntPtr)(this.int_11 + 4 + this.int_9 + (i - 1) * 52), num3 * 12 + this.int_7);
						}
						this.class1_0.method_20((IntPtr)(this.int_11 + 8 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[9]));
						this.class1_0.method_20((IntPtr)(this.int_11 + 9 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[10]));
						num3 = Convert.ToInt32(strArrays3[11]);
						if (num3 != 0)
						{
							this.class1_0.method_22((IntPtr)(this.int_11 + 12 + this.int_9 + (i - 1) * 52), num3 * 12 + this.int_7);
						}
						this.class1_0.method_20((IntPtr)(this.int_11 + 16 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[12]));
						this.class1_0.method_20((IntPtr)(this.int_11 + 17 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[13]));
						num3 = Convert.ToInt32(strArrays3[14]);
						if (num3 != 0)
						{
							this.class1_0.method_22((IntPtr)(this.int_11 + 20 + this.int_9 + (i - 1) * 52), num3 * 12 + this.int_7);
						}
						this.class1_0.method_20((IntPtr)(this.int_11 + 24 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[15]));
						this.class1_0.method_20((IntPtr)(this.int_11 + 25 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[16]));
						num3 = Convert.ToInt32(strArrays3[17]);
						if (num3 != 0)
						{
							this.class1_0.method_22((IntPtr)(this.int_11 + 28 + this.int_9 + (i - 1) * 52), num3 * 12 + this.int_7);
						}
						this.class1_0.method_20((IntPtr)(this.int_11 + 32 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[18]));
						this.class1_0.method_20((IntPtr)(this.int_11 + 33 + this.int_9 + (i - 1) * 52), Convert.ToByte(strArrays3[19]));
					}
					this.class1_0.method_22((IntPtr)(this.int_11 + this.int_9 + 1612), num2);
					this.method_3();
				}
			}
			catch
			{
				MessageBox.Show("Can't read file", "Hm...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void method_25()
		{
			int num;
			int num1 = this.class1_0.method_13((IntPtr)(this.int_5 + this.int_0));
			int num2 = this.class1_0.method_13((IntPtr)(this.int_5 + 4 + this.int_0));
			bool flag = true;
			this.int_14 = this.class1_0.method_13((IntPtr)(this.int_3 + this.int_0));
			this.int_15 = this.class1_0.method_13((IntPtr)(this.int_4 + this.int_0));
			if (this.class1_0.method_13((IntPtr)(this.int_15 + 16)) == 0)
			{
				MessageBox.Show("Please select driver profile and choose car to steal", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				if (this.class1_0.method_13((IntPtr)(this.int_15 + 16)) != this.class1_0.method_13((IntPtr)(this.int_14 + 16)))
				{
					return;
				}
				int[] int6 = this.int_6;
				int num3 = 0;
				while (true)
				{
					if (num3 < (int)int6.Length)
					{
						int num4 = int6[num3];
						if (this.class1_0.method_13((IntPtr)(this.int_15 + 16)) != num4)
						{
							num3++;
						}
						else
						{
							flag = false;
							break;
						}
					}
					else
					{
						break;
					}
				}
				if (!flag)
				{
					MessageBox.Show("U can't steal from this player :)", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (this.class1_0.method_13((IntPtr)(num1 + this.int_9 + 8)) == 0 && this.class1_0.method_13((IntPtr)(num2 + this.int_9 + 8)) == 0)
				{
					MessageBox.Show("Can't get vinyl data", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (this.class1_0.method_13((IntPtr)(num1 + this.int_9 + 8)) == 0)
				{
					this.int_13 = num2;
				}
				else
				{
					this.int_13 = num1;
				}
				int num5 = this.class1_0.method_13((IntPtr)(this.int_13 + 528 + 8));
				int int10 = num5 + this.int_10;
				int num6 = this.class1_0.method_13((IntPtr)(this.int_13 + this.int_9 + 8 + 1612));
				string str = "";
				int num7 = 1;
				int num8 = 31;
				if (this.saveDesc.Text == "")
				{
					this.saveDesc.Text = "No description";
				}
				for (int i = num7; i <= num8; i++)
				{
					num = this.class1_0.method_13((IntPtr)(this.int_13 + this.int_9 + 8 + (i - 1) * 52));
					if (num == 0)
					{
						num8 = i - 1;
					}
				}
				object[] objArray = new object[] { "STLV2!|Stolen work|Stolen by ", this.class1_0.method_9((IntPtr)(this.int_12 + 137), 14), ", ", this.saveDesc.Text, "|", num8, "||" };
				str = string.Concat(objArray);
				for (int j = num7; j <= num8; j++)
				{
					num = this.class1_0.method_13((IntPtr)(this.int_13 + this.int_9 + 8 + (j - 1) * 52));
					if (num == 0)
					{
						num8 = j;
					}
					else
					{
						num -= int10;
						int num9 = this.class1_0.method_12((IntPtr)(this.int_13 + 36 + this.int_9 + 8 + (j - 1) * 52));
						int num10 = this.class1_0.method_12((IntPtr)(this.int_13 + 38 + this.int_9 + 8 + (j - 1) * 52));
						int num11 = this.class1_0.method_12((IntPtr)(this.int_13 + 40 + this.int_9 + 8 + (j - 1) * 52));
						int num12 = this.class1_0.method_12((IntPtr)(this.int_13 + 42 + this.int_9 + 8 + (j - 1) * 52));
						int num13 = this.class1_0.method_11((IntPtr)(this.int_13 + 44 + this.int_9 + 8 + (j - 1) * 52));
						int num14 = this.class1_0.method_11((IntPtr)(this.int_13 + 45 + this.int_9 + 8 + (j - 1) * 52));
						int num15 = this.class1_0.method_13((IntPtr)(this.int_13 + 4 + this.int_9 + 8 + (j - 1) * 52));
						if (num15 != 0)
						{
							num15 = (num15 - num5) / 12;
						}
						int num16 = this.class1_0.method_11((IntPtr)(this.int_13 + 8 + this.int_9 + 8 + (j - 1) * 52));
						int num17 = this.class1_0.method_11((IntPtr)(this.int_13 + 9 + this.int_9 + 8 + (j - 1) * 52));
						int num18 = this.class1_0.method_13((IntPtr)(this.int_13 + 12 + this.int_9 + 8 + (j - 1) * 52));
						if (num18 != 0)
						{
							num18 = (num18 - num5) / 12;
						}
						int num19 = this.class1_0.method_11((IntPtr)(this.int_13 + 16 + this.int_9 + 8 + (j - 1) * 52));
						int num20 = this.class1_0.method_11((IntPtr)(this.int_13 + 17 + this.int_9 + 8 + (j - 1) * 52));
						int num21 = this.class1_0.method_13((IntPtr)(this.int_13 + 20 + this.int_9 + 8 + (j - 1) * 52));
						if (num21 != 0)
						{
							num21 = (num21 - num5) / 12;
						}
						int num22 = this.class1_0.method_11((IntPtr)(this.int_13 + 24 + this.int_9 + 8 + (j - 1) * 52));
						int num23 = this.class1_0.method_11((IntPtr)(this.int_13 + 25 + this.int_9 + 8 + (j - 1) * 52));
						int num24 = this.class1_0.method_13((IntPtr)(this.int_13 + 28 + this.int_9 + 8 + (j - 1) * 52));
						if (num24 != 0)
						{
							num24 = (num24 - num5) / 12;
						}
						int num25 = this.class1_0.method_11((IntPtr)(this.int_13 + 32 + this.int_9 + 8 + (j - 1) * 52));
						int num26 = this.class1_0.method_11((IntPtr)(this.int_13 + 33 + this.int_9 + 8 + (j - 1) * 52));
						int num27 = Convert.ToInt32(this.GetBit(num6, j));
						object[] objArray1 = new object[] { str, num, "|", num27, "|", num9, "|", num10, "|", num11, "|", num12, "|", num13, "|", num14, "|", num15, "|", num16, "|", num17, "|", num18, "|", num19, "|", num20, "|", num21, "|", num22, "|", num23, "|", num24, "|", num25, "|", num26, "||" };
						str = string.Concat(objArray1);
					}
				}
				str = string.Concat(str, "-1");
				if (this.OeMxuosSgo.Text == "")
				{
					this.OeMxuosSgo.Text = "StolenNoName";
				}
				string text = this.OeMxuosSgo.Text;
				string str1 = string.Concat(Directory.GetCurrentDirectory(), "\\VinylsDataNew\\");
				while (File.Exists(string.Concat(str1, text, ".svs")))
				{
					text = string.Concat(text, "+");
				}
				Class3 class3 = new Class3((int)base.Handle);
				str = class3.method_6(class3.method_9(str, true));
				try
				{
					using (FileStream fileStream = File.Create(string.Concat(str1, text, ".svs")))
					{
						byte[] bytes = (new UTF8Encoding(true)).GetBytes(str);
						fileStream.Write(bytes, 0, (int)bytes.Length);
					}
					this.listBox1.Items.Add(text);
					MessageBox.Show(string.Concat("Vinyl was save with name \"", this.OeMxuosSgo.Text, "\""), "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch
				{
					MessageBox.Show("Can't save vinyl", "Oh...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void method_3()
		{
			Rectangle rectangle = this.gMtZudvhFe.method_0();
			this.class6_0.method_1(135, (short)(rectangle.Height - 76));
		}

		private void method_4()
		{
			if ((int)Process.GetProcessesByName(this.string_2).Length == 0)
			{
				this.bool_2 = true;
			}
			if (this.bool_2)
			{
				this.class1_0.method_0();
				this.string_2 = this.class1_0.method_1();
				this.string_3 = this.class1_0.method_2();
				this.intptr_0 = this.class1_0.method_3();
				this.int_0 = this.class1_0.method_4(this.string_3);
				if (this.intptr_0 != (IntPtr)-1)
				{
					this.bool_2 = false;
					this.class6_0 = new Class6(Form1.string_0);
					this.gMtZudvhFe = new Class4(Form1.string_0);
				}
			}
		}

		private void method_5()
		{
			try
			{
				this.int_35 = (int)this.layerPanel1X.Value;
				this.int_36 = (int)this.layerPanel1Y.Value;
				this.int_37 = (int)this.layerPanel1sX.Value;
				this.int_38 = (int)this.layerPanel1sY.Value;
				this.int_39 = (int)this.layerPanel1r.Value;
				this.int_40 = (int)this.layerPanel1s.Value;
				this.int_41 = (int)this.layerPanel1c1h.Value;
				this.int_42 = (int)this.layerPanel1c1x.Value;
				this.int_43 = (int)this.layerPanel1c1y.Value;
				this.int_44 = (int)this.layerPanel1c2h.Value;
				this.int_45 = (int)this.layerPanel1c2x.Value;
				this.int_46 = (int)this.layerPanel1c2y.Value;
				this.int_47 = (int)this.layerPanel1c3h.Value;
				this.int_48 = (int)this.layerPanel1c3x.Value;
				this.int_49 = (int)this.layerPanel1c3y.Value;
				this.int_50 = (int)this.layerPanel1c4h.Value;
				this.int_51 = (int)this.layerPanel1c4x.Value;
				this.int_52 = (int)this.layerPanel1c4y.Value;
			}
			catch
			{
			}
		}

		private void method_6()
		{
			try
			{
				this.int_35 = (int)this.layerPanel2X.Value;
				this.int_36 = (int)this.layerPanel2Y.Value;
				this.int_37 = (int)this.layerPanel2sX.Value;
				this.int_38 = (int)this.layerPanel2sY.Value;
				this.int_39 = (int)this.layerPanel2r.Value;
				this.int_40 = (int)this.layerPanel2s.Value;
				this.int_41 = (int)this.layerPanel2c1h.Value;
				this.int_42 = (int)this.layerPanel2c1x.Value;
				this.int_43 = (int)this.layerPanel2c1y.Value;
				this.int_44 = (int)this.layerPanel2c2h.Value;
				this.int_45 = (int)this.layerPanel2c2x.Value;
				this.int_46 = (int)this.layerPanel2c2y.Value;
				this.int_47 = (int)this.layerPanel2c3h.Value;
				this.int_48 = (int)this.layerPanel2c3x.Value;
				this.int_49 = (int)this.layerPanel2c3y.Value;
				this.int_50 = (int)this.layerPanel2c4h.Value;
				this.int_51 = (int)this.layerPanel2c4x.Value;
				this.int_52 = (int)this.layerPanel2c4y.Value;
			}
			catch
			{
			}
		}

		private void method_7()
		{
			try
			{
				this.int_35 = (int)this.layerPanel3X.Value;
				this.int_36 = (int)this.layerPanel3Y.Value;
				this.int_37 = (int)this.layerPanel3sX.Value;
				this.int_38 = (int)this.layerPanel3sY.Value;
				this.int_39 = (int)this.layerPanel3r.Value;
				this.int_40 = (int)this.layerPanel3s.Value;
				this.int_41 = (int)this.layerPanel3c1h.Value;
				this.int_42 = (int)this.layerPanel3c1x.Value;
				this.int_43 = (int)this.layerPanel3c1y.Value;
				this.int_44 = (int)this.layerPanel3c2h.Value;
				this.int_45 = (int)this.layerPanel3c2x.Value;
				this.int_46 = (int)this.layerPanel3c2y.Value;
				this.int_47 = (int)this.layerPanel3c3h.Value;
				this.int_48 = (int)this.BdsEcsiibb.Value;
				this.int_49 = (int)this.layerPanel3c3y.Value;
				this.int_50 = (int)this.layerPanel3c4h.Value;
				this.int_51 = (int)this.layerPanel3c4x.Value;
				this.int_52 = (int)this.layerPanel3c4y.Value;
			}
			catch
			{
			}
		}

		private void method_8()
		{
		}

		private void method_9()
		{
			this.playerNameLabel.Text = this.string_5;
		}

		private void MirrorButton_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.int_65 = this.SetBit(this.int_65, Convert.ToInt32(this.layerToMirror.Value), !this.bool_12);
				this.class1_0.method_22((IntPtr)(this.int_11 + this.int_9 + 1612), this.int_65);
				this.method_3();
			}
		}

		private void pjeyWarbaH()
		{
			MessageBox.Show("No server to communicate...", "Jebaited", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void RaNyhyUqHk(object sender, EventArgs e)
		{
			this.bool_6 = true;
		}

		private void refreshAuto_Click(object sender, EventArgs e)
		{
			this.bool_11 = !this.bool_11;
			if (this.bool_11)
			{
				this.refreshAuto.Text = "Refresh ON";
				return;
			}
			this.refreshAuto.Text = "Refresh OFF";
		}

		private void refreshFolder_Click(object sender, EventArgs e)
		{
			if (this.bool_13)
			{
				this.method_21();
				return;
			}
			this.pjeyWarbaH();
		}

		private void rvByEaweAH(object sender, EventArgs e)
		{
			this.bool_5 = true;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			this.method_20();
		}

		public int SetBit(int b, int bitNumber, bool l)
		{
			if (bitNumber >= 32 || bitNumber <= 0)
			{
				return b;
			}
			if (l)
			{
				return b | 1 << (bitNumber - 1 & 31);
			}
			return b & ~(1 << (bitNumber - 1 & 31));
		}

		private void uploadButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("No server to communicate...", "Jebaited", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void xkeezLciuf(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel2r.Value);
			if (num < 0)
			{
				this.layerPanel2r.Value = new decimal(255);
			}
			if (num > 255)
			{
				this.layerPanel2r.Value = new decimal(0);
			}
			this.bool_7 = true;
		}

		private void XplefkUpyX(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel3c4h.Value);
			if (num < 0)
			{
				this.layerPanel3c4h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel3c4h.Value = new decimal(0);
			}
			this.bool_8 = true;
		}

		private void YxBeHdIhkb(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.layerPanel2c4h.Value);
			if (num < 0)
			{
				this.layerPanel2c4h.Value = new decimal(89);
			}
			if (num > 89)
			{
				this.layerPanel2c4h.Value = new decimal(0);
			}
			this.bool_7 = true;
		}

		private delegate void Delegate0();

		private delegate void Delegate1();

		private delegate void Delegate2();

		private delegate void Delegate3();

		private delegate void Delegate4();

		private delegate void Delegate5();

		private delegate void Delegate6();

		private delegate void Delegate7();
	}
}