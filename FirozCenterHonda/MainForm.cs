namespace FirozCenterHonda
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class MainForm : Form
    {
        private ToolStripMenuItem admintoolStripMenuItem;
        private ToolStripMenuItem advancePayToolStripMenuItem;
        private ToolStripMenuItem backupRestoreToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem1;
        private ToolStripMenuItem bankToolStripMenuItem;
        private ToolStripMenuItem bankToolStripMenuItem1;
        private ToolStripMenuItem bankToolStripMenuItem2;
        private ToolStripMenuItem businessSummaryToolStripMenuItem;
        private Button button1;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button2;
        private Button button20;
        private Button button21;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ToolStripMenuItem cashSummaryToolStripMenuItem;
        private ToolStripMenuItem changePriceToolStripMenuItem;
        private ToolStripMenuItem editSales;
        private ToolStripMenuItem changeUpdateToolStripMenuItem;
        private IContainer components = null;
        private ToolStripMenuItem contactNumberToolStripMenuItem;
        private ToolStripMenuItem customerINfoToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem1;
        private ToolStripMenuItem dailyToolStripMenuItem3;
        private DBConnect dbc = new DBConnect();
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem depositeToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem editInventory;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem10;
        private ToolStripMenuItem editToolStripMenuItem11;
        private ToolStripMenuItem editService;
        private ToolStripMenuItem editParty;
        private ToolStripMenuItem editToolStripMenuItem4;
        private ToolStripMenuItem editToolStripMenuItem5;
        private ToolStripMenuItem editExpences;
        private ToolStripMenuItem editBank;
        private ToolStripMenuItem editToolStripMenuItem8;
        private ToolStripMenuItem editDue;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem engineOilReportToolStripMenuItem;
        private ToolStripMenuItem engineOilToolStripMenuItem;
        private ToolStripMenuItem engineOilToolStripMenuItem1;
        private ToolStripMenuItem engineOilToolStripMenuItem2;
        private ToolStripMenuItem engineOilToolStripMenuItem3;
        private ToolStripMenuItem expensesToolStripMenuItem;
        private GroupBox groupBoxInventory;
        private GroupBox groupBoxStock;
        private GroupBox groupBoxSales;
        private GroupBox groupBoxPurchase;
        private GroupBox groupBoxExpences;
        private GroupBox groupBoxDue;
        private GroupBox groupBoxBank;
        private GroupBox groupBoxSalesReport;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private ToolStripMenuItem loadExcelToolStripMenuItem;
        private ToolStripMenuItem lonaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem monthlyToolStripMenuItem2;
        private ToolStripMenuItem monthlyToolStripMenuItem3;
        private ToolStripMenuItem monthlyToolStripMenuItem4;
        private ToolStripMenuItem motorCycleDetailsToolStripMenuItem;
        private ToolStripMenuItem motorCycleStockReportToolStripMenuItem;
        private ToolStripMenuItem motorCycleSummaryToolStripMenuItem;
        private ToolStripMenuItem motorCycleToolStripMenuItem;
        private ToolStripMenuItem motorCycleToolStripMenuItem1;
        private ToolStripMenuItem motorCycleToolStripMenuItem10;
        private ToolStripMenuItem motorCycleToolStripMenuItem11;
        private ToolStripMenuItem motorCycleToolStripMenuItem12;
        private ToolStripMenuItem motorCycleToolStripMenuItem13;
        private ToolStripMenuItem motorCycleToolStripMenuItem14;
        private ToolStripMenuItem motorCycleToolStripMenuItem2;
        private ToolStripMenuItem motorCycleToolStripMenuItem3;
        private ToolStripMenuItem motorCycleToolStripMenuItem4;
        private ToolStripMenuItem motorCycleToolStripMenuItem5;
        private ToolStripMenuItem motorCycleToolStripMenuItem6;
        private ToolStripMenuItem motorCycleToolStripMenuItem7;
        private ToolStripMenuItem motorCycleToolStripMenuItem8;
        private ToolStripMenuItem motorCycleToolStripMenuItem9;
        private ToolStripMenuItem nameToolStripMenuItem;
        private ToolStripMenuItem nameToolStripMenuItem1;
        private ToolStripMenuItem newEnteryToolStripMenuItem;
        private ToolStripMenuItem newEntreyToolStripMenuItem;
        private ToolStripMenuItem newEntryToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem2;
        private ToolStripMenuItem newToolStripMenuItem3;
        private ToolStripMenuItem newToolStripMenuItem4;
        private ToolStripMenuItem newToolStripMenuItem5;
        private ToolStripMenuItem newToolStripMenuItem7;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Panel panel1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel2;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel25;
        private Panel panel26;
        private Panel panel27;
        private Panel panel28;
        private Panel panel29;
        private Panel panel3;
        private Panel panel30;
        private Panel panel31;
        private Panel panel32;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private ToolStripMenuItem partsStockReportToolStripMenuItem;
        private ToolStripMenuItem partsStockReportWithPriceToolStripMenuItem;
        private ToolStripMenuItem partsSummaryToolStripMenuItem;
        private ToolStripMenuItem partsToolStripMenuItem;
        private ToolStripMenuItem partsToolStripMenuItem1;
        private ToolStripMenuItem partsToolStripMenuItem10;
        private ToolStripMenuItem partsToolStripMenuItem11;
        private ToolStripMenuItem partsToolStripMenuItem12;
        private ToolStripMenuItem partsToolStripMenuItem13;
        private ToolStripMenuItem partsToolStripMenuItem14;
        private ToolStripMenuItem partsToolStripMenuItem15;
        private ToolStripMenuItem partsToolStripMenuItem16;
        private ToolStripMenuItem partsToolStripMenuItem17;
        private ToolStripMenuItem partsToolStripMenuItem2;
        private ToolStripMenuItem partsToolStripMenuItem3;
        private ToolStripMenuItem partsToolStripMenuItem4;
        private ToolStripMenuItem partsToolStripMenuItem5;
        private ToolStripMenuItem partsToolStripMenuItem6;
        private ToolStripMenuItem partsToolStripMenuItem7;
        private ToolStripMenuItem partsToolStripMenuItem8;
        private ToolStripMenuItem partsToolStripMenuItem9;
        private ToolStripMenuItem partyInfoToolStripMenuItem;
        private ToolStripMenuItem partyToolStripMenuItem;
        private ToolStripMenuItem partyToolStripMenuItem1;
        private ToolStripMenuItem dueToolStripMenuItem;
        private ToolStripMenuItem petiCashToolStripMenuItem;
        private ToolStripMenuItem postToolStripMenuItem;
        private ToolStripMenuItem priceUpdateToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem1;
        private ToolStripMenuItem profitLossToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem1;
        private ToolStripMenuItem receiveToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem1;
        private ToolStripMenuItem reportToolStripMenuItem2;
        private ToolStripMenuItem reportToolStripMenuItem3;
        private ToolStripMenuItem reportToolStripMenuItem4;
        private ToolStripMenuItem reportToolStripMenuItem5;
        private ToolStripMenuItem reportToolStripMenuItem6;
        private ToolStripMenuItem reportToolStripMenuItem7;
        private ToolStripMenuItem reportToolStripMenuItem8;
        private ToolStripMenuItem salaryToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem serviceToolStripMenuItem;
        private ToolStripMenuItem serviceToolStripMenuItem1;
        private ToolStripMenuItem serviceToolStripMenuItem2;
        private ToolStripMenuItem serviceToolStripMenuItem3;
        private ToolStripMenuItem serviceToolStripMenuItem4;
        private ToolStripMenuItem serviceToolStripMenuItem5;
        private ToolStripMenuItem serviceToolStripMenuItem6;
        private ToolStripMenuItem serviceToolStripMenuItem7;
        private ToolStripMenuItem serviceToolStripMenuItem8;
        private ToolStripMenuItem stockToolStripMenuItem;
        private Timer timer2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem transcationToolStripMenuItem;
        private ToolStripMenuItem transcationToolStripMenuItem1;
        private ToolStripMenuItem transcationToolStripMenuItem2;
        private ToolStripMenuItem updateMotorCycleStatusToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem vehiclesToolStripMenuItem;
        private ToolStripMenuItem priceListToolStripMenuItem;
        private ToolStripMenuItem contactToolStripMenuItem;
        private ToolStripMenuItem partsPartyPriceToolStripMenuItem;
        private ToolStripMenuItem dueServiceToolStripMenuItem;
        private ToolStripMenuItem servicingReportToolStripMenuItem;
        private ToolStripMenuItem summeryToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem1;
        private ToolStripMenuItem userToolStripMenuItem2;
        private ToolStripMenuItem motorcyclePriceToolStripMenuItem;
        private ToolStripMenuItem modelToolStripMenuItem;
        private ToolStripMenuItem contactNumberToolStripMenuItem1;
        private ToolStripMenuItem invoiceNoToolStripMenuItem;
        private ToolStripMenuItem vehicleToolStripMenuItem;

        public MainForm(string user)
        {
            this.InitializeComponent();
            this.timer2.Enabled = true;
            this.timer2.Interval = 0x3e8;
            this.label6.Text = "User: " + user;
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str2 = string.Format("{0:dd-MMM-yyyy}", now);
            this.label4.Text = "Date: " + str2;
            
            string str = this.dbc.SelectSingle("Select access_level FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("normal"))
            {
                this.employeeToolStripMenuItem.Enabled = false;
                this.transcationToolStripMenuItem.Enabled = false;
                this.admintoolStripMenuItem.Enabled = false;
                this.deleteToolStripMenuItem.Enabled = false;

                this.editBank.Enabled = false;
                this.editDue.Enabled = false;
                this.editExpences.Enabled = false;
                this.editInventory.Enabled = false;
                this.editParty.Enabled = false;
                this.editSales.Enabled = false;
                this.editService.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab1 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.inventoryToolStripMenuItem.Enabled = false;
                this.groupBoxInventory.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab2 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.stockToolStripMenuItem.Enabled = false;
                this.groupBoxStock.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab3 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.salesToolStripMenuItem.Enabled = false;
                this.groupBoxSales.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab4 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.serviceToolStripMenuItem1.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab8 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.partyToolStripMenuItem.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab7 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.expensesToolStripMenuItem.Enabled = false;
                this.groupBoxExpences.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab6 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.bankToolStripMenuItem.Enabled = false;
                this.groupBoxBank.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab5 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.dueToolStripMenuItem.Enabled = false;
                this.groupBoxDue.Enabled = false;
            }

            str = this.dbc.SelectSingle("Select tab9 FROM firoz_center.tbl_user where name='" + user + "'");
            if (str.Equals("False"))
            {
                this.deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void advancePayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeAdvancePayment().Show();
        }

        private void allMotorCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportMotorCycle().Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new DBConnect().DatabaseBackup(@"C:\xampp\mysql\bin\mysqldump.exe", "firoz_center");
            new DBConnect().Backup();
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //new DBConnect().DatabaseBackup(@"C:\xampp\mysql\bin\mysqldump.exe", "firoz_center");
            new DBConnect().Backup();
        }

        private void bankToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddNewBank().Show();
        }

        private void bankToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EditBankInfo().Show();
        }

        private void businessSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BUsinessSummary().Show();
        }

        private void button_5(object sender, EventArgs e)
        {
            new ReportMonthlySalesParts().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewPurchaseMotorCycle().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new NewExpences().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new ReportMonthlySalesMotorCycle().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new NewSalesMotorCycle().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            new DueReport("Parts").Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new DueReport("Service").Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new TranscationMonthly().Show();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            new NewBankDeposite().Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new ReportMonthlyPurchaseParts().Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            new ReportBankTranscation().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NewPurchaseParts().Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new NewBankTranscation().Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            new ReportMonthlyPurchaseMotorCycle().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new StockPartsReport().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new StockReportMotorCycleDaily().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new NewSalesParts().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ReportMonthlySaleService().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new NewSaleService().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ReportExpences().Show();
        }

        private void cashSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CashSummary().Show();
        }

        private void changeUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeInformationUpdate().Show();
        }

        private void contactNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerContactNumber().Show();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditCustomerInfo().Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateCustomer().Show();
        }

        private void dailyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void dailyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new StockReportMotorCycleDaily().Show();
        }

        
        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewBankDeposite().Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockReportPartsDetails().Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DuePaymentMotorCycle().Show();
        }

        private void editToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            AddOrder order = new AddOrder();
            order.Show();
            order.load_order_id();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EditSaleService().Show();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new EditPartyTranscation().Show();
        }

        private void editToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new EditUser().Show();
        }

        private void editToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new EditExpences().Show();
        }

        private void editToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new EditBankTranscation().Show();
        }

        private void editToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new EditCustomerInfo().Show();
        }

        private void editToolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }

        private void engineOilReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockReportEngineOilMonthly().Show();
        }

        private void engineOilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewSalesEngineOil().Show();
        }

        private void engineOilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PrintEngineOil().Show();
        }

        private void engineOilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ReportMonthlySalesEngineOil().Show();
        }

        private void engineOilToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new EditSalesEngineOil().Show();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bankToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorcyclePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.engineOilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.engineOilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineOilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsPartyPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSales = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.engineOilToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.transcationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.transcationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsStockReportWithPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMotorCycleStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineOilReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summeryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.postToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editService = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dueServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancePayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.editParty = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editExpences = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.depositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBank = new System.Windows.Forms.ToolStripMenuItem();
            this.transcationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerINfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEnteryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.priceUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.admintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntreyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petiCashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDue = new System.Windows.Forms.ToolStripMenuItem();
            this.motorCycleToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.partsToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDue = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBoxSales = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBoxStock = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInventory = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxBank = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBoxPurchase = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.groupBoxExpences = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.groupBoxSalesReport = new System.Windows.Forms.GroupBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDue.SuspendLayout();
            this.groupBoxSales.SuspendLayout();
            this.groupBoxStock.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxInventory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.groupBoxBank.SuspendLayout();
            this.groupBoxPurchase.SuspendLayout();
            this.groupBoxExpences.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.groupBoxSalesReport.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankToolStripMenuItem1
            // 
            this.bankToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bankToolStripMenuItem1.Name = "bankToolStripMenuItem1";
            this.bankToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.bankToolStripMenuItem1.Text = "Bank Info.";
            this.bankToolStripMenuItem1.Click += new System.EventHandler(this.bankToolStripMenuItem1_Click);
            // 
            // partyInfoToolStripMenuItem
            // 
            this.partyInfoToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partyInfoToolStripMenuItem.Name = "partyInfoToolStripMenuItem";
            this.partyInfoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.partyInfoToolStripMenuItem.Text = "Party Info.";
            this.partyInfoToolStripMenuItem.Click += new System.EventHandler(this.partyInfoToolStripMenuItem_Click);
            // 
            // partsToolStripMenuItem3
            // 
            this.partsToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem3.Name = "partsToolStripMenuItem3";
            this.partsToolStripMenuItem3.Size = new System.Drawing.Size(184, 22);
            this.partsToolStripMenuItem3.Text = "Parts";
            this.partsToolStripMenuItem3.Click += new System.EventHandler(this.partsToolStripMenuItem3_Click);
            // 
            // motorCycleToolStripMenuItem1
            // 
            this.motorCycleToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem1.Name = "motorCycleToolStripMenuItem1";
            this.motorCycleToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.motorCycleToolStripMenuItem1.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem1.Click += new System.EventHandler(this.motorCycleToolStripMenuItem1_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            this.serviceToolStripMenuItem.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // changePriceToolStripMenuItem
            // 
            this.changePriceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.changePriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem1,
            this.partsToolStripMenuItem3,
            this.serviceToolStripMenuItem2,
            this.motorcyclePriceToolStripMenuItem});
            this.changePriceToolStripMenuItem.Name = "changePriceToolStripMenuItem";
            this.changePriceToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.changePriceToolStripMenuItem.Text = "Change Price";
            // 
            // serviceToolStripMenuItem2
            // 
            this.serviceToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem2.Name = "serviceToolStripMenuItem2";
            this.serviceToolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.serviceToolStripMenuItem2.Text = "Service";
            this.serviceToolStripMenuItem2.Click += new System.EventHandler(this.serviceToolStripMenuItem2_Click);
            // 
            // motorcyclePriceToolStripMenuItem
            // 
            this.motorcyclePriceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorcyclePriceToolStripMenuItem.Name = "motorcyclePriceToolStripMenuItem";
            this.motorcyclePriceToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.motorcyclePriceToolStripMenuItem.Text = "Motorcycle Price";
            this.motorcyclePriceToolStripMenuItem.Click += new System.EventHandler(this.motorcyclePriceToolStripMenuItem_Click);
            // 
            // partsToolStripMenuItem2
            // 
            this.partsToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem2.Name = "partsToolStripMenuItem2";
            this.partsToolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem2.Text = "Parts";
            this.partsToolStripMenuItem2.Click += new System.EventHandler(this.partsToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem7,
            this.partsToolStripMenuItem10,
            this.engineOilToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.editToolStripMenuItem1.Text = "Print ";
            // 
            // motorCycleToolStripMenuItem7
            // 
            this.motorCycleToolStripMenuItem7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem7.Name = "motorCycleToolStripMenuItem7";
            this.motorCycleToolStripMenuItem7.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem7.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem7.Click += new System.EventHandler(this.motorCycleToolStripMenuItem7_Click);
            // 
            // partsToolStripMenuItem10
            // 
            this.partsToolStripMenuItem10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem10.Name = "partsToolStripMenuItem10";
            this.partsToolStripMenuItem10.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem10.Text = "Parts";
            this.partsToolStripMenuItem10.Click += new System.EventHandler(this.partsToolStripMenuItem10_Click);
            // 
            // engineOilToolStripMenuItem1
            // 
            this.engineOilToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.engineOilToolStripMenuItem1.Name = "engineOilToolStripMenuItem1";
            this.engineOilToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.engineOilToolStripMenuItem1.Text = "Engine Oil";
            this.engineOilToolStripMenuItem1.Click += new System.EventHandler(this.engineOilToolStripMenuItem1_Click);
            // 
            // partsToolStripMenuItem1
            // 
            this.partsToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem1.Name = "partsToolStripMenuItem1";
            this.partsToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem1.Text = "Parts";
            this.partsToolStripMenuItem1.Click += new System.EventHandler(this.partsToolStripMenuItem1_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.vehiclesToolStripMenuItem.Text = "Motor Cycle";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesToolStripMenuItem,
            this.partsToolStripMenuItem1,
            this.engineOilToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // engineOilToolStripMenuItem
            // 
            this.engineOilToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.engineOilToolStripMenuItem.Name = "engineOilToolStripMenuItem";
            this.engineOilToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.engineOilToolStripMenuItem.Text = "Engine Oil";
            this.engineOilToolStripMenuItem.Click += new System.EventHandler(this.engineOilToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.reportToolStripMenuItem1,
            this.editSales});
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem5,
            this.partsToolStripMenuItem7,
            this.partsSummaryToolStripMenuItem,
            this.engineOilToolStripMenuItem2,
            this.partsPartyPriceToolStripMenuItem});
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.reportToolStripMenuItem1.Text = "Report";
            // 
            // motorCycleToolStripMenuItem5
            // 
            this.motorCycleToolStripMenuItem5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem5.Name = "motorCycleToolStripMenuItem5";
            this.motorCycleToolStripMenuItem5.Size = new System.Drawing.Size(186, 22);
            this.motorCycleToolStripMenuItem5.Text = "MotorCycle";
            this.motorCycleToolStripMenuItem5.Click += new System.EventHandler(this.motorCycleToolStripMenuItem5_Click_1);
            // 
            // partsToolStripMenuItem7
            // 
            this.partsToolStripMenuItem7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem7.Name = "partsToolStripMenuItem7";
            this.partsToolStripMenuItem7.Size = new System.Drawing.Size(186, 22);
            this.partsToolStripMenuItem7.Text = "Parts";
            this.partsToolStripMenuItem7.Click += new System.EventHandler(this.partsToolStripMenuItem7_Click_1);
            // 
            // partsSummaryToolStripMenuItem
            // 
            this.partsSummaryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsSummaryToolStripMenuItem.Name = "partsSummaryToolStripMenuItem";
            this.partsSummaryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.partsSummaryToolStripMenuItem.Text = "Parts Summary";
            this.partsSummaryToolStripMenuItem.Click += new System.EventHandler(this.partsSummaryToolStripMenuItem_Click);
            // 
            // engineOilToolStripMenuItem2
            // 
            this.engineOilToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.engineOilToolStripMenuItem2.Name = "engineOilToolStripMenuItem2";
            this.engineOilToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.engineOilToolStripMenuItem2.Text = "Engine Oil";
            this.engineOilToolStripMenuItem2.Click += new System.EventHandler(this.engineOilToolStripMenuItem2_Click);
            // 
            // partsPartyPriceToolStripMenuItem
            // 
            this.partsPartyPriceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsPartyPriceToolStripMenuItem.Name = "partsPartyPriceToolStripMenuItem";
            this.partsPartyPriceToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.partsPartyPriceToolStripMenuItem.Text = "Parts Party Price";
            this.partsPartyPriceToolStripMenuItem.Click += new System.EventHandler(this.partsPartyPriceToolStripMenuItem_Click);
            // 
            // editSales
            // 
            this.editSales.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem8,
            this.partsToolStripMenuItem9,
            this.engineOilToolStripMenuItem3});
            this.editSales.Name = "editSales";
            this.editSales.Size = new System.Drawing.Size(118, 22);
            this.editSales.Text = "Edit";
            // 
            // motorCycleToolStripMenuItem8
            // 
            this.motorCycleToolStripMenuItem8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem8.Name = "motorCycleToolStripMenuItem8";
            this.motorCycleToolStripMenuItem8.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem8.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem8.Click += new System.EventHandler(this.motorCycleToolStripMenuItem8_Click_1);
            // 
            // partsToolStripMenuItem9
            // 
            this.partsToolStripMenuItem9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem9.Name = "partsToolStripMenuItem9";
            this.partsToolStripMenuItem9.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem9.Text = "Parts";
            this.partsToolStripMenuItem9.Click += new System.EventHandler(this.partsToolStripMenuItem9_Click_1);
            // 
            // engineOilToolStripMenuItem3
            // 
            this.engineOilToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.engineOilToolStripMenuItem3.Name = "engineOilToolStripMenuItem3";
            this.engineOilToolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.engineOilToolStripMenuItem3.Text = "Engine Oil";
            this.engineOilToolStripMenuItem3.Click += new System.EventHandler(this.engineOilToolStripMenuItem3_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem6,
            this.partsToolStripMenuItem8});
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(268, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // motorCycleToolStripMenuItem6
            // 
            this.motorCycleToolStripMenuItem6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem6.Name = "motorCycleToolStripMenuItem6";
            this.motorCycleToolStripMenuItem6.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem6.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem6.Click += new System.EventHandler(this.motorCycleToolStripMenuItem6_Click_1);
            // 
            // partsToolStripMenuItem8
            // 
            this.partsToolStripMenuItem8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem8.Name = "partsToolStripMenuItem8";
            this.partsToolStripMenuItem8.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem8.Text = "Parts";
            this.partsToolStripMenuItem8.Click += new System.EventHandler(this.partsToolStripMenuItem8_Click_1);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.motorCycleDetailsToolStripMenuItem,
            this.motorCycleStockReportToolStripMenuItem,
            this.partsStockReportToolStripMenuItem,
            this.partsStockReportWithPriceToolStripMenuItem,
            this.updateMotorCycleStatusToolStripMenuItem,
            this.engineOilReportToolStripMenuItem});
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // motorCycleDetailsToolStripMenuItem
            // 
            this.motorCycleDetailsToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleDetailsToolStripMenuItem.Name = "motorCycleDetailsToolStripMenuItem";
            this.motorCycleDetailsToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.motorCycleDetailsToolStripMenuItem.Text = "Motor Cycle Details";
            this.motorCycleDetailsToolStripMenuItem.Click += new System.EventHandler(this.motorCycleDetailsToolStripMenuItem_Click);
            // 
            // motorCycleStockReportToolStripMenuItem
            // 
            this.motorCycleStockReportToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleStockReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem3,
            this.monthlyToolStripMenuItem3,
            this.transcationToolStripMenuItem2,
            this.modelToolStripMenuItem});
            this.motorCycleStockReportToolStripMenuItem.Name = "motorCycleStockReportToolStripMenuItem";
            this.motorCycleStockReportToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.motorCycleStockReportToolStripMenuItem.Text = "Motor Cycle Stock Report";
            // 
            // dailyToolStripMenuItem3
            // 
            this.dailyToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dailyToolStripMenuItem3.Name = "dailyToolStripMenuItem3";
            this.dailyToolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.dailyToolStripMenuItem3.Text = "Daily";
            this.dailyToolStripMenuItem3.Click += new System.EventHandler(this.dailyToolStripMenuItem3_Click);
            // 
            // monthlyToolStripMenuItem3
            // 
            this.monthlyToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.monthlyToolStripMenuItem3.Name = "monthlyToolStripMenuItem3";
            this.monthlyToolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.monthlyToolStripMenuItem3.Text = "Monthly";
            this.monthlyToolStripMenuItem3.Click += new System.EventHandler(this.motorCycleStockReportToolStripMenuItem_Click);
            // 
            // transcationToolStripMenuItem2
            // 
            this.transcationToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.transcationToolStripMenuItem2.Name = "transcationToolStripMenuItem2";
            this.transcationToolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.transcationToolStripMenuItem2.Text = "Transcation";
            this.transcationToolStripMenuItem2.Click += new System.EventHandler(this.transcationToolStripMenuItem2_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // partsStockReportToolStripMenuItem
            // 
            this.partsStockReportToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsStockReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyToolStripMenuItem4,
            this.transcationToolStripMenuItem1,
            this.detailsToolStripMenuItem});
            this.partsStockReportToolStripMenuItem.Name = "partsStockReportToolStripMenuItem";
            this.partsStockReportToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.partsStockReportToolStripMenuItem.Text = "Parts Stock Report";
            // 
            // monthlyToolStripMenuItem4
            // 
            this.monthlyToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.monthlyToolStripMenuItem4.Name = "monthlyToolStripMenuItem4";
            this.monthlyToolStripMenuItem4.Size = new System.Drawing.Size(156, 22);
            this.monthlyToolStripMenuItem4.Text = "Monthly";
            this.monthlyToolStripMenuItem4.Click += new System.EventHandler(this.partsStockReportToolStripMenuItem_Click);
            // 
            // transcationToolStripMenuItem1
            // 
            this.transcationToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.transcationToolStripMenuItem1.Name = "transcationToolStripMenuItem1";
            this.transcationToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.transcationToolStripMenuItem1.Text = "Transcation";
            this.transcationToolStripMenuItem1.Click += new System.EventHandler(this.transcationToolStripMenuItem1_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // partsStockReportWithPriceToolStripMenuItem
            // 
            this.partsStockReportWithPriceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsStockReportWithPriceToolStripMenuItem.Name = "partsStockReportWithPriceToolStripMenuItem";
            this.partsStockReportWithPriceToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.partsStockReportWithPriceToolStripMenuItem.Text = "Parts Stock Report with Price";
            this.partsStockReportWithPriceToolStripMenuItem.Click += new System.EventHandler(this.partsStockReportWithPriceToolStripMenuItem_Click);
            // 
            // updateMotorCycleStatusToolStripMenuItem
            // 
            this.updateMotorCycleStatusToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.updateMotorCycleStatusToolStripMenuItem.Name = "updateMotorCycleStatusToolStripMenuItem";
            this.updateMotorCycleStatusToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.updateMotorCycleStatusToolStripMenuItem.Text = "Update Motor Cycle Status";
            this.updateMotorCycleStatusToolStripMenuItem.Click += new System.EventHandler(this.updateMotorCycleStatusToolStripMenuItem_Click);
            // 
            // engineOilReportToolStripMenuItem
            // 
            this.engineOilReportToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.engineOilReportToolStripMenuItem.Name = "engineOilReportToolStripMenuItem";
            this.engineOilReportToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.engineOilReportToolStripMenuItem.Text = "Engine Oil Report";
            this.engineOilReportToolStripMenuItem.Click += new System.EventHandler(this.engineOilReportToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem3,
            this.partsToolStripMenuItem5,
            this.motorCycleSummaryToolStripMenuItem,
            this.summeryToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // motorCycleToolStripMenuItem3
            // 
            this.motorCycleToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem3.Name = "motorCycleToolStripMenuItem3";
            this.motorCycleToolStripMenuItem3.Size = new System.Drawing.Size(218, 22);
            this.motorCycleToolStripMenuItem3.Text = "MotorCycle";
            this.motorCycleToolStripMenuItem3.Click += new System.EventHandler(this.motorCycleToolStripMenuItem3_Click_1);
            // 
            // partsToolStripMenuItem5
            // 
            this.partsToolStripMenuItem5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem5.Name = "partsToolStripMenuItem5";
            this.partsToolStripMenuItem5.Size = new System.Drawing.Size(218, 22);
            this.partsToolStripMenuItem5.Text = "Parts";
            this.partsToolStripMenuItem5.Click += new System.EventHandler(this.partsToolStripMenuItem5_Click_1);
            // 
            // motorCycleSummaryToolStripMenuItem
            // 
            this.motorCycleSummaryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleSummaryToolStripMenuItem.Name = "motorCycleSummaryToolStripMenuItem";
            this.motorCycleSummaryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.motorCycleSummaryToolStripMenuItem.Text = "MotorCycle Summary";
            this.motorCycleSummaryToolStripMenuItem.Click += new System.EventHandler(this.motorCycleSummaryToolStripMenuItem_Click);
            // 
            // summeryToolStripMenuItem
            // 
            this.summeryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.summeryToolStripMenuItem.Name = "summeryToolStripMenuItem";
            this.summeryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.summeryToolStripMenuItem.Text = "Summery";
            this.summeryToolStripMenuItem.Click += new System.EventHandler(this.summeryToolStripMenuItem_Click);
            // 
            // partsToolStripMenuItem4
            // 
            this.partsToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem4.Name = "partsToolStripMenuItem4";
            this.partsToolStripMenuItem4.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem4.Text = "Parts";
            this.partsToolStripMenuItem4.Click += new System.EventHandler(this.partsToolStripMenuItem4_Click_1);
            // 
            // motorCycleToolStripMenuItem2
            // 
            this.motorCycleToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem2.Name = "motorCycleToolStripMenuItem2";
            this.motorCycleToolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem2.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem2.Click += new System.EventHandler(this.motorCycleToolStripMenuItem2_Click);
            // 
            // editInventory
            // 
            this.editInventory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem2,
            this.partsToolStripMenuItem4,
            this.invoiceNoToolStripMenuItem});
            this.editInventory.Name = "editInventory";
            this.editInventory.Size = new System.Drawing.Size(118, 22);
            this.editInventory.Text = "Edit";
            // 
            // invoiceNoToolStripMenuItem
            // 
            this.invoiceNoToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.invoiceNoToolStripMenuItem.Name = "invoiceNoToolStripMenuItem";
            this.invoiceNoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.invoiceNoToolStripMenuItem.Text = "Invoice No";
            this.invoiceNoToolStripMenuItem.Click += new System.EventHandler(this.invoiceNoToolStripMenuItem_Click);
            // 
            // partsToolStripMenuItem
            // 
            this.partsToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem.Name = "partsToolStripMenuItem";
            this.partsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem.Text = "Parts";
            this.partsToolStripMenuItem.Click += new System.EventHandler(this.partsToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.vehicleToolStripMenuItem.Text = "Motor Cycle";
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleToolStripMenuItem,
            this.partsToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem7,
            this.editToolStripMenuItem11,
            this.postToolStripMenuItem,
            this.reportToolStripMenuItem5});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // newToolStripMenuItem7
            // 
            this.newToolStripMenuItem7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem7.Name = "newToolStripMenuItem7";
            this.newToolStripMenuItem7.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem7.Text = "New";
            this.newToolStripMenuItem7.Click += new System.EventHandler(this.newToolStripMenuItem7_Click);
            // 
            // editToolStripMenuItem11
            // 
            this.editToolStripMenuItem11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editToolStripMenuItem11.Name = "editToolStripMenuItem11";
            this.editToolStripMenuItem11.Size = new System.Drawing.Size(118, 22);
            this.editToolStripMenuItem11.Text = "Add";
            this.editToolStripMenuItem11.Click += new System.EventHandler(this.editToolStripMenuItem11_Click);
            // 
            // postToolStripMenuItem
            // 
            this.postToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.postToolStripMenuItem.Name = "postToolStripMenuItem";
            this.postToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.postToolStripMenuItem.Text = "Post";
            this.postToolStripMenuItem.Click += new System.EventHandler(this.postToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem5
            // 
            this.reportToolStripMenuItem5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem5.Name = "reportToolStripMenuItem5";
            this.reportToolStripMenuItem5.Size = new System.Drawing.Size(118, 22);
            this.reportToolStripMenuItem5.Text = "Report";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editInventory,
            this.reportToolStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.serviceToolStripMenuItem1,
            this.employeeToolStripMenuItem,
            this.partyToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.bankToolStripMenuItem,
            this.transcationToolStripMenuItem,
            this.userToolStripMenuItem,
            this.admintoolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.dueToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 26);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviceToolStripMenuItem1
            // 
            this.serviceToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.editService,
            this.reportToolStripMenuItem2,
            this.dueServiceToolStripMenuItem,
            this.servicingReportToolStripMenuItem});
            this.serviceToolStripMenuItem1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.serviceToolStripMenuItem1.Name = "serviceToolStripMenuItem1";
            this.serviceToolStripMenuItem1.Size = new System.Drawing.Size(70, 22);
            this.serviceToolStripMenuItem1.Text = "Service";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.newToolStripMenuItem2.Text = "New";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.newToolStripMenuItem2_Click);
            // 
            // editService
            // 
            this.editService.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editService.Name = "editService";
            this.editService.Size = new System.Drawing.Size(185, 22);
            this.editService.Text = "Edit";
            this.editService.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // reportToolStripMenuItem2
            // 
            this.reportToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem2.Name = "reportToolStripMenuItem2";
            this.reportToolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.reportToolStripMenuItem2.Text = "Report";
            this.reportToolStripMenuItem2.Click += new System.EventHandler(this.reportToolStripMenuItem2_Click);
            // 
            // dueServiceToolStripMenuItem
            // 
            this.dueServiceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dueServiceToolStripMenuItem.Name = "dueServiceToolStripMenuItem";
            this.dueServiceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dueServiceToolStripMenuItem.Text = "Due Service";
            this.dueServiceToolStripMenuItem.Click += new System.EventHandler(this.dueServiceToolStripMenuItem_Click);
            // 
            // servicingReportToolStripMenuItem
            // 
            this.servicingReportToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.servicingReportToolStripMenuItem.Name = "servicingReportToolStripMenuItem";
            this.servicingReportToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.servicingReportToolStripMenuItem.Text = "Servicing Report";
            this.servicingReportToolStripMenuItem.Click += new System.EventHandler(this.servicingReportToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.changeUpdateToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.lonaToolStripMenuItem,
            this.advancePayToolStripMenuItem,
            this.reportToolStripMenuItem7,
            this.printToolStripMenuItem1});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newEntryToolStripMenuItem.Text = "New Entry";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // changeUpdateToolStripMenuItem
            // 
            this.changeUpdateToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.changeUpdateToolStripMenuItem.Name = "changeUpdateToolStripMenuItem";
            this.changeUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeUpdateToolStripMenuItem.Text = "Change/Update";
            this.changeUpdateToolStripMenuItem.Click += new System.EventHandler(this.changeUpdateToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // lonaToolStripMenuItem
            // 
            this.lonaToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lonaToolStripMenuItem.Name = "lonaToolStripMenuItem";
            this.lonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lonaToolStripMenuItem.Text = "Loan";
            this.lonaToolStripMenuItem.Click += new System.EventHandler(this.lonaToolStripMenuItem_Click);
            // 
            // advancePayToolStripMenuItem
            // 
            this.advancePayToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.advancePayToolStripMenuItem.Name = "advancePayToolStripMenuItem";
            this.advancePayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.advancePayToolStripMenuItem.Text = "Advance Pay";
            this.advancePayToolStripMenuItem.Click += new System.EventHandler(this.advancePayToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem7
            // 
            this.reportToolStripMenuItem7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem7.Name = "reportToolStripMenuItem7";
            this.reportToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem7.Text = "Report";
            this.reportToolStripMenuItem7.Click += new System.EventHandler(this.reportToolStripMenuItem7_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem4,
            this.editParty,
            this.reportToolStripMenuItem4});
            this.partyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.partyToolStripMenuItem.Text = "Party";
            // 
            // newToolStripMenuItem4
            // 
            this.newToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem4.Name = "newToolStripMenuItem4";
            this.newToolStripMenuItem4.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem4.Text = "New";
            this.newToolStripMenuItem4.Click += new System.EventHandler(this.newToolStripMenuItem4_Click);
            // 
            // editParty
            // 
            this.editParty.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editParty.Name = "editParty";
            this.editParty.Size = new System.Drawing.Size(116, 22);
            this.editParty.Text = "Edit";
            this.editParty.Click += new System.EventHandler(this.editToolStripMenuItem3_Click);
            // 
            // reportToolStripMenuItem4
            // 
            this.reportToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem4.Name = "reportToolStripMenuItem4";
            this.reportToolStripMenuItem4.Size = new System.Drawing.Size(116, 22);
            this.reportToolStripMenuItem4.Text = "Report";
            this.reportToolStripMenuItem4.Click += new System.EventHandler(this.reportToolStripMenuItem4_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem5,
            this.editExpences,
            this.reportToolStripMenuItem8});
            this.expensesToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // newToolStripMenuItem5
            // 
            this.newToolStripMenuItem5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem5.Name = "newToolStripMenuItem5";
            this.newToolStripMenuItem5.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem5.Text = "New";
            this.newToolStripMenuItem5.Click += new System.EventHandler(this.newToolStripMenuItem5_Click);
            // 
            // editExpences
            // 
            this.editExpences.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editExpences.Name = "editExpences";
            this.editExpences.Size = new System.Drawing.Size(118, 22);
            this.editExpences.Text = "Edit";
            this.editExpences.Click += new System.EventHandler(this.editToolStripMenuItem6_Click);
            // 
            // reportToolStripMenuItem8
            // 
            this.reportToolStripMenuItem8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem8.Name = "reportToolStripMenuItem8";
            this.reportToolStripMenuItem8.Size = new System.Drawing.Size(118, 22);
            this.reportToolStripMenuItem8.Text = "Report";
            this.reportToolStripMenuItem8.Click += new System.EventHandler(this.reportToolStripMenuItem8_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem3,
            this.reportToolStripMenuItem3,
            this.depositeToolStripMenuItem,
            this.editBank});
            this.bankToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.bankToolStripMenuItem.Text = "Bank";
            // 
            // newToolStripMenuItem3
            // 
            this.newToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newToolStripMenuItem3.Name = "newToolStripMenuItem3";
            this.newToolStripMenuItem3.Size = new System.Drawing.Size(176, 22);
            this.newToolStripMenuItem3.Text = "New Deposite";
            this.newToolStripMenuItem3.Click += new System.EventHandler(this.newToolStripMenuItem3_Click);
            // 
            // reportToolStripMenuItem3
            // 
            this.reportToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem3.Name = "reportToolStripMenuItem3";
            this.reportToolStripMenuItem3.Size = new System.Drawing.Size(176, 22);
            this.reportToolStripMenuItem3.Text = "Bank Report";
            this.reportToolStripMenuItem3.Click += new System.EventHandler(this.reportToolStripMenuItem3_Click);
            // 
            // depositeToolStripMenuItem
            // 
            this.depositeToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.depositeToolStripMenuItem.Name = "depositeToolStripMenuItem";
            this.depositeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.depositeToolStripMenuItem.Text = "Cash Wihtdraw";
            this.depositeToolStripMenuItem.Click += new System.EventHandler(this.depositeToolStripMenuItem_Click);
            // 
            // editBank
            // 
            this.editBank.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editBank.Name = "editBank";
            this.editBank.Size = new System.Drawing.Size(176, 22);
            this.editBank.Text = "Edit Deposite";
            this.editBank.Click += new System.EventHandler(this.editToolStripMenuItem7_Click);
            // 
            // transcationToolStripMenuItem
            // 
            this.transcationToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.transcationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyToolStripMenuItem2});
            this.transcationToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transcationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.transcationToolStripMenuItem.Name = "transcationToolStripMenuItem";
            this.transcationToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.transcationToolStripMenuItem.Text = "Transcation";
            // 
            // monthlyToolStripMenuItem2
            // 
            this.monthlyToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.monthlyToolStripMenuItem2.Name = "monthlyToolStripMenuItem2";
            this.monthlyToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.monthlyToolStripMenuItem2.Text = "Monthly";
            this.monthlyToolStripMenuItem2.Click += new System.EventHandler(this.monthlyToolStripMenuItem2_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem4,
            this.customerINfoToolStripMenuItem,
            this.newEnteryToolStripMenuItem,
            this.editToolStripMenuItem10,
            this.backupToolStripMenuItem1,
            this.priceUpdateToolStripMenuItem,
            this.priceListToolStripMenuItem,
            this.contactNumberToolStripMenuItem1});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // editToolStripMenuItem4
            // 
            this.editToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editToolStripMenuItem4.Name = "editToolStripMenuItem4";
            this.editToolStripMenuItem4.Size = new System.Drawing.Size(184, 22);
            this.editToolStripMenuItem4.Text = "Edit";
            this.editToolStripMenuItem4.Click += new System.EventHandler(this.editToolStripMenuItem4_Click);
            // 
            // customerINfoToolStripMenuItem
            // 
            this.customerINfoToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customerINfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem8,
            this.replaceToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.customerINfoToolStripMenuItem.Name = "customerINfoToolStripMenuItem";
            this.customerINfoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customerINfoToolStripMenuItem.Text = "Customer Info";
            // 
            // editToolStripMenuItem8
            // 
            this.editToolStripMenuItem8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editToolStripMenuItem8.Name = "editToolStripMenuItem8";
            this.editToolStripMenuItem8.Size = new System.Drawing.Size(127, 22);
            this.editToolStripMenuItem8.Text = "Edit";
            this.editToolStripMenuItem8.Click += new System.EventHandler(this.editToolStripMenuItem8_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // newEnteryToolStripMenuItem
            // 
            this.newEnteryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newEnteryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem10,
            this.partsToolStripMenuItem12,
            this.serviceToolStripMenuItem6});
            this.newEnteryToolStripMenuItem.Name = "newEnteryToolStripMenuItem";
            this.newEnteryToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newEnteryToolStripMenuItem.Text = "New Entery";
            // 
            // motorCycleToolStripMenuItem10
            // 
            this.motorCycleToolStripMenuItem10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem10.Name = "motorCycleToolStripMenuItem10";
            this.motorCycleToolStripMenuItem10.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem10.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem10.Click += new System.EventHandler(this.motorCycleToolStripMenuItem_Click);
            // 
            // partsToolStripMenuItem12
            // 
            this.partsToolStripMenuItem12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem12.Name = "partsToolStripMenuItem12";
            this.partsToolStripMenuItem12.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem12.Text = "Parts";
            this.partsToolStripMenuItem12.Click += new System.EventHandler(this.partsToolStripMenuItem2_Click);
            // 
            // serviceToolStripMenuItem6
            // 
            this.serviceToolStripMenuItem6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem6.Name = "serviceToolStripMenuItem6";
            this.serviceToolStripMenuItem6.Size = new System.Drawing.Size(153, 22);
            this.serviceToolStripMenuItem6.Text = "Service";
            this.serviceToolStripMenuItem6.Click += new System.EventHandler(this.serviceToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem10
            // 
            this.editToolStripMenuItem10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editToolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem11,
            this.partsToolStripMenuItem13,
            this.serviceToolStripMenuItem7});
            this.editToolStripMenuItem10.Name = "editToolStripMenuItem10";
            this.editToolStripMenuItem10.Size = new System.Drawing.Size(184, 22);
            this.editToolStripMenuItem10.Text = "Edit";
            // 
            // motorCycleToolStripMenuItem11
            // 
            this.motorCycleToolStripMenuItem11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem11.Name = "motorCycleToolStripMenuItem11";
            this.motorCycleToolStripMenuItem11.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem11.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem11.Click += new System.EventHandler(this.motorCycleToolStripMenuItem4_Click_1);
            // 
            // partsToolStripMenuItem13
            // 
            this.partsToolStripMenuItem13.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem13.Name = "partsToolStripMenuItem13";
            this.partsToolStripMenuItem13.Size = new System.Drawing.Size(153, 22);
            this.partsToolStripMenuItem13.Text = "Parts";
            this.partsToolStripMenuItem13.Click += new System.EventHandler(this.partsToolStripMenuItem6_Click_1);
            // 
            // serviceToolStripMenuItem7
            // 
            this.serviceToolStripMenuItem7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem7.Name = "serviceToolStripMenuItem7";
            this.serviceToolStripMenuItem7.Size = new System.Drawing.Size(153, 22);
            this.serviceToolStripMenuItem7.Text = "Service";
            // 
            // backupToolStripMenuItem1
            // 
            this.backupToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
            this.backupToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.backupToolStripMenuItem1.Text = "Backup";
            this.backupToolStripMenuItem1.Click += new System.EventHandler(this.backupToolStripMenuItem1_Click);
            // 
            // priceUpdateToolStripMenuItem
            // 
            this.priceUpdateToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.priceUpdateToolStripMenuItem.Name = "priceUpdateToolStripMenuItem";
            this.priceUpdateToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.priceUpdateToolStripMenuItem.Text = "Price Update";
            this.priceUpdateToolStripMenuItem.Click += new System.EventHandler(this.priceUpdateToolStripMenuItem_Click);
            // 
            // priceListToolStripMenuItem
            // 
            this.priceListToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.priceListToolStripMenuItem.Name = "priceListToolStripMenuItem";
            this.priceListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.priceListToolStripMenuItem.Text = "Price List";
            this.priceListToolStripMenuItem.Click += new System.EventHandler(this.priceListToolStripMenuItem_Click);
            // 
            // contactNumberToolStripMenuItem1
            // 
            this.contactNumberToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contactNumberToolStripMenuItem1.Name = "contactNumberToolStripMenuItem1";
            this.contactNumberToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.contactNumberToolStripMenuItem1.Text = "Contact Number";
            this.contactNumberToolStripMenuItem1.Click += new System.EventHandler(this.contactNumberToolStripMenuItem1_Click);
            // 
            // admintoolStripMenuItem
            // 
            this.admintoolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.admintoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntreyToolStripMenuItem,
            this.changePriceToolStripMenuItem,
            this.partsToolStripMenuItem17,
            this.partyInfoToolStripMenuItem,
            this.bankToolStripMenuItem1,
            this.editToolStripMenuItem5,
            this.loadExcelToolStripMenuItem,
            this.petiCashToolStripMenuItem,
            this.cashSummaryToolStripMenuItem,
            this.businessSummaryToolStripMenuItem,
            this.backupRestoreToolStripMenuItem,
            this.contactNumberToolStripMenuItem,
            this.profitLossToolStripMenuItem});
            this.admintoolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admintoolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.admintoolStripMenuItem.Name = "admintoolStripMenuItem";
            this.admintoolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.admintoolStripMenuItem.Text = "Admin";
            // 
            // newEntreyToolStripMenuItem
            // 
            this.newEntreyToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newEntreyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem,
            this.partsToolStripMenuItem2,
            this.serviceToolStripMenuItem,
            this.userToolStripMenuItem1});
            this.newEntreyToolStripMenuItem.Name = "newEntreyToolStripMenuItem";
            this.newEntreyToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.newEntreyToolStripMenuItem.Text = "New Entrey";
            // 
            // motorCycleToolStripMenuItem
            // 
            this.motorCycleToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem.Name = "motorCycleToolStripMenuItem";
            this.motorCycleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.motorCycleToolStripMenuItem.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem.Click += new System.EventHandler(this.motorCycleToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // partsToolStripMenuItem17
            // 
            this.partsToolStripMenuItem17.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem17.Name = "partsToolStripMenuItem17";
            this.partsToolStripMenuItem17.Size = new System.Drawing.Size(206, 22);
            this.partsToolStripMenuItem17.Text = "Parts";
            this.partsToolStripMenuItem17.Click += new System.EventHandler(this.partsToolStripMenuItem17_Click);
            // 
            // editToolStripMenuItem5
            // 
            this.editToolStripMenuItem5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem4,
            this.partsToolStripMenuItem6,
            this.partyToolStripMenuItem1,
            this.bankToolStripMenuItem2,
            this.customerToolStripMenuItem,
            this.customerToolStripMenuItem1,
            this.serviceToolStripMenuItem8,
            this.userToolStripMenuItem2});
            this.editToolStripMenuItem5.Name = "editToolStripMenuItem5";
            this.editToolStripMenuItem5.Size = new System.Drawing.Size(206, 22);
            this.editToolStripMenuItem5.Text = "Edit";
            // 
            // motorCycleToolStripMenuItem4
            // 
            this.motorCycleToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem4.Name = "motorCycleToolStripMenuItem4";
            this.motorCycleToolStripMenuItem4.Size = new System.Drawing.Size(170, 22);
            this.motorCycleToolStripMenuItem4.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem4.Click += new System.EventHandler(this.motorCycleToolStripMenuItem4_Click_1);
            // 
            // partsToolStripMenuItem6
            // 
            this.partsToolStripMenuItem6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem6.Name = "partsToolStripMenuItem6";
            this.partsToolStripMenuItem6.Size = new System.Drawing.Size(170, 22);
            this.partsToolStripMenuItem6.Text = "Parts";
            this.partsToolStripMenuItem6.Click += new System.EventHandler(this.partsToolStripMenuItem6_Click_1);
            // 
            // partyToolStripMenuItem1
            // 
            this.partyToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partyToolStripMenuItem1.Name = "partyToolStripMenuItem1";
            this.partyToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.partyToolStripMenuItem1.Text = "Party";
            this.partyToolStripMenuItem1.Click += new System.EventHandler(this.partyToolStripMenuItem1_Click);
            // 
            // bankToolStripMenuItem2
            // 
            this.bankToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bankToolStripMenuItem2.Name = "bankToolStripMenuItem2";
            this.bankToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.bankToolStripMenuItem2.Text = "Bank";
            this.bankToolStripMenuItem2.Click += new System.EventHandler(this.bankToolStripMenuItem2_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.customerToolStripMenuItem.Text = "Customer Info";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.customerToolStripMenuItem1.Text = "Customer ";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.customerToolStripMenuItem1_Click);
            // 
            // serviceToolStripMenuItem8
            // 
            this.serviceToolStripMenuItem8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem8.Name = "serviceToolStripMenuItem8";
            this.serviceToolStripMenuItem8.Size = new System.Drawing.Size(170, 22);
            this.serviceToolStripMenuItem8.Text = "Service";
            this.serviceToolStripMenuItem8.Click += new System.EventHandler(this.serviceToolStripMenuItem8_Click);
            // 
            // userToolStripMenuItem2
            // 
            this.userToolStripMenuItem2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.userToolStripMenuItem2.Name = "userToolStripMenuItem2";
            this.userToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.userToolStripMenuItem2.Text = "User";
            this.userToolStripMenuItem2.Click += new System.EventHandler(this.userToolStripMenuItem2_Click);
            // 
            // loadExcelToolStripMenuItem
            // 
            this.loadExcelToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loadExcelToolStripMenuItem.Name = "loadExcelToolStripMenuItem";
            this.loadExcelToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.loadExcelToolStripMenuItem.Text = "Load Excel";
            this.loadExcelToolStripMenuItem.Click += new System.EventHandler(this.loadExcelToolStripMenuItem_Click);
            // 
            // petiCashToolStripMenuItem
            // 
            this.petiCashToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.petiCashToolStripMenuItem.Name = "petiCashToolStripMenuItem";
            this.petiCashToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.petiCashToolStripMenuItem.Text = "Petty Cash";
            this.petiCashToolStripMenuItem.Click += new System.EventHandler(this.petiCashToolStripMenuItem_Click);
            // 
            // cashSummaryToolStripMenuItem
            // 
            this.cashSummaryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cashSummaryToolStripMenuItem.Name = "cashSummaryToolStripMenuItem";
            this.cashSummaryToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cashSummaryToolStripMenuItem.Text = "Cash Summary";
            this.cashSummaryToolStripMenuItem.Click += new System.EventHandler(this.cashSummaryToolStripMenuItem_Click);
            // 
            // businessSummaryToolStripMenuItem
            // 
            this.businessSummaryToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.businessSummaryToolStripMenuItem.Name = "businessSummaryToolStripMenuItem";
            this.businessSummaryToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.businessSummaryToolStripMenuItem.Text = "Business Summary";
            this.businessSummaryToolStripMenuItem.Click += new System.EventHandler(this.businessSummaryToolStripMenuItem_Click);
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backupRestoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.backupRestoreToolStripMenuItem.Text = "Backup/Restore";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // contactNumberToolStripMenuItem
            // 
            this.contactNumberToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.contactNumberToolStripMenuItem.Name = "contactNumberToolStripMenuItem";
            this.contactNumberToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.contactNumberToolStripMenuItem.Text = "Contact Number";
            this.contactNumberToolStripMenuItem.Click += new System.EventHandler(this.contactNumberToolStripMenuItem_Click);
            // 
            // profitLossToolStripMenuItem
            // 
            this.profitLossToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.profitLossToolStripMenuItem.Name = "profitLossToolStripMenuItem";
            this.profitLossToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.profitLossToolStripMenuItem.Text = "Profit Loss";
            this.profitLossToolStripMenuItem.Click += new System.EventHandler(this.profitLossToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem1,
            this.saleToolStripMenuItem});
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem1
            // 
            this.purchaseToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.purchaseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem13,
            this.partsToolStripMenuItem15});
            this.purchaseToolStripMenuItem1.Name = "purchaseToolStripMenuItem1";
            this.purchaseToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.purchaseToolStripMenuItem1.Text = "Purchase";
            // 
            // motorCycleToolStripMenuItem13
            // 
            this.motorCycleToolStripMenuItem13.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem13.Name = "motorCycleToolStripMenuItem13";
            this.motorCycleToolStripMenuItem13.Size = new System.Drawing.Size(147, 22);
            this.motorCycleToolStripMenuItem13.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem13.Click += new System.EventHandler(this.motorCycleToolStripMenuItem13_Click);
            // 
            // partsToolStripMenuItem15
            // 
            this.partsToolStripMenuItem15.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem15.Name = "partsToolStripMenuItem15";
            this.partsToolStripMenuItem15.Size = new System.Drawing.Size(147, 22);
            this.partsToolStripMenuItem15.Text = "Parts";
            this.partsToolStripMenuItem15.Click += new System.EventHandler(this.partsToolStripMenuItem15_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem14,
            this.partsToolStripMenuItem16,
            this.serviceToolStripMenuItem3});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // motorCycleToolStripMenuItem14
            // 
            this.motorCycleToolStripMenuItem14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem14.Name = "motorCycleToolStripMenuItem14";
            this.motorCycleToolStripMenuItem14.Size = new System.Drawing.Size(147, 22);
            this.motorCycleToolStripMenuItem14.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem14.Click += new System.EventHandler(this.motorCycleToolStripMenuItem14_Click);
            // 
            // partsToolStripMenuItem16
            // 
            this.partsToolStripMenuItem16.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem16.Name = "partsToolStripMenuItem16";
            this.partsToolStripMenuItem16.Size = new System.Drawing.Size(147, 22);
            this.partsToolStripMenuItem16.Text = "Parts";
            this.partsToolStripMenuItem16.Click += new System.EventHandler(this.partsToolStripMenuItem16_Click);
            // 
            // serviceToolStripMenuItem3
            // 
            this.serviceToolStripMenuItem3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem3.Name = "serviceToolStripMenuItem3";
            this.serviceToolStripMenuItem3.Size = new System.Drawing.Size(147, 22);
            this.serviceToolStripMenuItem3.Text = "Service";
            this.serviceToolStripMenuItem3.Click += new System.EventHandler(this.serviceToolStripMenuItem3_Click);
            // 
            // dueToolStripMenuItem
            // 
            this.dueToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem6,
            this.nameToolStripMenuItem1,
            this.receiveToolStripMenuItem,
            this.editDue});
            this.dueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dueToolStripMenuItem.Name = "dueToolStripMenuItem";
            this.dueToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.dueToolStripMenuItem.Text = "Due";
            // 
            // reportToolStripMenuItem6
            // 
            this.reportToolStripMenuItem6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reportToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem12,
            this.partsToolStripMenuItem14,
            this.serviceToolStripMenuItem4,
            this.nameToolStripMenuItem});
            this.reportToolStripMenuItem6.Name = "reportToolStripMenuItem6";
            this.reportToolStripMenuItem6.Size = new System.Drawing.Size(122, 22);
            this.reportToolStripMenuItem6.Text = "Report";
            // 
            // motorCycleToolStripMenuItem12
            // 
            this.motorCycleToolStripMenuItem12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem12.Name = "motorCycleToolStripMenuItem12";
            this.motorCycleToolStripMenuItem12.Size = new System.Drawing.Size(147, 22);
            this.motorCycleToolStripMenuItem12.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem12.Click += new System.EventHandler(this.motorCycleToolStripMenuItem12_Click);
            // 
            // partsToolStripMenuItem14
            // 
            this.partsToolStripMenuItem14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem14.Name = "partsToolStripMenuItem14";
            this.partsToolStripMenuItem14.Size = new System.Drawing.Size(147, 22);
            this.partsToolStripMenuItem14.Text = "Parts";
            this.partsToolStripMenuItem14.Click += new System.EventHandler(this.partsToolStripMenuItem14_Click);
            // 
            // serviceToolStripMenuItem4
            // 
            this.serviceToolStripMenuItem4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem4.Name = "serviceToolStripMenuItem4";
            this.serviceToolStripMenuItem4.Size = new System.Drawing.Size(147, 22);
            this.serviceToolStripMenuItem4.Text = "Service";
            this.serviceToolStripMenuItem4.Click += new System.EventHandler(this.serviceToolStripMenuItem4_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem1
            // 
            this.nameToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nameToolStripMenuItem1.Name = "nameToolStripMenuItem1";
            this.nameToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.nameToolStripMenuItem1.Text = "Name";
            this.nameToolStripMenuItem1.Click += new System.EventHandler(this.nameToolStripMenuItem1_Click);
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.receiveToolStripMenuItem.Text = "Receive";
            this.receiveToolStripMenuItem.Click += new System.EventHandler(this.receiveToolStripMenuItem_Click);
            // 
            // editDue
            // 
            this.editDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editDue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorCycleToolStripMenuItem9,
            this.partsToolStripMenuItem11,
            this.serviceToolStripMenuItem5});
            this.editDue.Name = "editDue";
            this.editDue.Size = new System.Drawing.Size(122, 22);
            this.editDue.Text = "Edit";
            this.editDue.Click += new System.EventHandler(this.editToolStripMenuItem9_Click);
            // 
            // motorCycleToolStripMenuItem9
            // 
            this.motorCycleToolStripMenuItem9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.motorCycleToolStripMenuItem9.Name = "motorCycleToolStripMenuItem9";
            this.motorCycleToolStripMenuItem9.Size = new System.Drawing.Size(147, 22);
            this.motorCycleToolStripMenuItem9.Text = "Motor Cycle";
            this.motorCycleToolStripMenuItem9.Click += new System.EventHandler(this.motorCycleToolStripMenuItem9_Click_1);
            // 
            // partsToolStripMenuItem11
            // 
            this.partsToolStripMenuItem11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.partsToolStripMenuItem11.Name = "partsToolStripMenuItem11";
            this.partsToolStripMenuItem11.Size = new System.Drawing.Size(147, 22);
            this.partsToolStripMenuItem11.Text = "Parts";
            this.partsToolStripMenuItem11.Click += new System.EventHandler(this.partsToolStripMenuItem11_Click_2);
            // 
            // serviceToolStripMenuItem5
            // 
            this.serviceToolStripMenuItem5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.serviceToolStripMenuItem5.Name = "serviceToolStripMenuItem5";
            this.serviceToolStripMenuItem5.Size = new System.Drawing.Size(147, 22);
            this.serviceToolStripMenuItem5.Text = "Service";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 22);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBoxDue
            // 
            this.groupBoxDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxDue.Controls.Add(this.button16);
            this.groupBoxDue.Controls.Add(this.button13);
            this.groupBoxDue.Controls.Add(this.button14);
            this.groupBoxDue.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDue.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxDue.Location = new System.Drawing.Point(15, 46);
            this.groupBoxDue.Name = "groupBoxDue";
            this.groupBoxDue.Size = new System.Drawing.Size(125, 110);
            this.groupBoxDue.TabIndex = 54;
            this.groupBoxDue.TabStop = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button16.Location = new System.Drawing.Point(8, 75);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 25);
            this.button16.TabIndex = 6;
            this.button16.Text = "Service";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button13.Location = new System.Drawing.Point(8, 46);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(109, 25);
            this.button13.TabIndex = 5;
            this.button13.Text = "Parts";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button14.Location = new System.Drawing.Point(8, 17);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(109, 25);
            this.button14.TabIndex = 4;
            this.button14.Text = "Motor Cycle";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Receive);
            // 
            // groupBoxSales
            // 
            this.groupBoxSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSales.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxSales.Controls.Add(this.button6);
            this.groupBoxSales.Controls.Add(this.button8);
            this.groupBoxSales.Controls.Add(this.button12);
            this.groupBoxSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSales.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBoxSales.Location = new System.Drawing.Point(16, 46);
            this.groupBoxSales.Name = "groupBoxSales";
            this.groupBoxSales.Size = new System.Drawing.Size(125, 110);
            this.groupBoxSales.TabIndex = 47;
            this.groupBoxSales.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button6.Location = new System.Drawing.Point(8, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 25);
            this.button6.TabIndex = 4;
            this.button6.Text = "Parts";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button8.Location = new System.Drawing.Point(8, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 25);
            this.button8.TabIndex = 1;
            this.button8.Text = "Service";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button12.Location = new System.Drawing.Point(8, 17);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 25);
            this.button12.TabIndex = 1;
            this.button12.Text = "Motor Cycle";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(8, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 25);
            this.button5.TabIndex = 5;
            this.button5.Text = "Parts";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_5);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button7.Location = new System.Drawing.Point(8, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 25);
            this.button7.TabIndex = 2;
            this.button7.Text = "Service";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button11.Location = new System.Drawing.Point(8, 17);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 25);
            this.button11.TabIndex = 2;
            this.button11.Text = "Motor Cycle";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBoxStock
            // 
            this.groupBoxStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStock.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxStock.Controls.Add(this.button3);
            this.groupBoxStock.Controls.Add(this.button4);
            this.groupBoxStock.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStock.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxStock.Location = new System.Drawing.Point(15, 46);
            this.groupBoxStock.Name = "groupBoxStock";
            this.groupBoxStock.Size = new System.Drawing.Size(125, 110);
            this.groupBoxStock.TabIndex = 46;
            this.groupBoxStock.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(8, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Parts";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(8, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 25);
            this.button4.TabIndex = 1;
            this.button4.Text = "Motor Cycle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(16, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 24);
            this.panel4.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(31, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "SALES";
            // 
            // groupBoxInventory
            // 
            this.groupBoxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInventory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxInventory.Controls.Add(this.button2);
            this.groupBoxInventory.Controls.Add(this.button1);
            this.groupBoxInventory.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInventory.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxInventory.Location = new System.Drawing.Point(16, 46);
            this.groupBoxInventory.Name = "groupBoxInventory";
            this.groupBoxInventory.Size = new System.Drawing.Size(125, 110);
            this.groupBoxInventory.TabIndex = 45;
            this.groupBoxInventory.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(8, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(8, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Motor Cycle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.panel22);
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Controls.Add(this.panel20);
            this.panel3.Location = new System.Drawing.Point(670, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 110);
            this.panel3.TabIndex = 49;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel22.Controls.Add(this.label4);
            this.panel22.Location = new System.Drawing.Point(13, 70);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(187, 24);
            this.panel22.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "DATE:";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.label5);
            this.panel21.Location = new System.Drawing.Point(13, 43);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(187, 24);
            this.panel21.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIME:                    ";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Controls.Add(this.label6);
            this.panel20.Location = new System.Drawing.Point(13, 16);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(187, 24);
            this.panel20.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "USER:  Admin";
            // 
            // groupBoxBank
            // 
            this.groupBoxBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBank.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxBank.Controls.Add(this.button17);
            this.groupBoxBank.Controls.Add(this.button19);
            this.groupBoxBank.Controls.Add(this.button20);
            this.groupBoxBank.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBank.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxBank.Location = new System.Drawing.Point(15, 46);
            this.groupBoxBank.Name = "groupBoxBank";
            this.groupBoxBank.Size = new System.Drawing.Size(125, 110);
            this.groupBoxBank.TabIndex = 53;
            this.groupBoxBank.TabStop = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button17.Location = new System.Drawing.Point(8, 75);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(109, 25);
            this.button17.TabIndex = 6;
            this.button17.Text = "Withdraw";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button19.Location = new System.Drawing.Point(8, 46);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(109, 25);
            this.button19.TabIndex = 5;
            this.button19.Text = "Report";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button20.Location = new System.Drawing.Point(8, 17);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(109, 25);
            this.button20.TabIndex = 4;
            this.button20.Text = "Deposite";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // groupBoxPurchase
            // 
            this.groupBoxPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPurchase.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxPurchase.Controls.Add(this.button18);
            this.groupBoxPurchase.Controls.Add(this.button21);
            this.groupBoxPurchase.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPurchase.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxPurchase.Location = new System.Drawing.Point(15, 46);
            this.groupBoxPurchase.Name = "groupBoxPurchase";
            this.groupBoxPurchase.Size = new System.Drawing.Size(125, 110);
            this.groupBoxPurchase.TabIndex = 51;
            this.groupBoxPurchase.TabStop = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button18.Location = new System.Drawing.Point(8, 46);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(109, 25);
            this.button18.TabIndex = 8;
            this.button18.Text = "Parts";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button21.Location = new System.Drawing.Point(8, 17);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(109, 25);
            this.button21.TabIndex = 7;
            this.button21.Text = "Motor Cycle";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // groupBoxExpences
            // 
            this.groupBoxExpences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExpences.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxExpences.Controls.Add(this.button9);
            this.groupBoxExpences.Controls.Add(this.button10);
            this.groupBoxExpences.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExpences.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxExpences.Location = new System.Drawing.Point(16, 46);
            this.groupBoxExpences.Name = "groupBoxExpences";
            this.groupBoxExpences.Size = new System.Drawing.Size(125, 110);
            this.groupBoxExpences.TabIndex = 48;
            this.groupBoxExpences.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button9.Location = new System.Drawing.Point(8, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 25);
            this.button9.TabIndex = 2;
            this.button9.Text = "Report";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button10.Location = new System.Drawing.Point(8, 17);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 25);
            this.button10.TabIndex = 1;
            this.button10.Text = "New";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel9.Controls.Add(this.panel25);
            this.panel9.Controls.Add(this.panel23);
            this.panel9.Location = new System.Drawing.Point(670, 147);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(214, 73);
            this.panel9.TabIndex = 55;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.label7);
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Location = new System.Drawing.Point(13, 38);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(187, 24);
            this.panel25.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(2, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Motor Cycle Stock:";
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel26.Location = new System.Drawing.Point(-1, 31);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(187, 24);
            this.panel26.TabIndex = 56;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.label9);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Location = new System.Drawing.Point(13, 12);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(187, 24);
            this.panel23.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(2, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Parts Stock:";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Location = new System.Drawing.Point(-1, 31);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(187, 24);
            this.panel24.TabIndex = 56;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel15.Controls.Add(this.panel31);
            this.panel15.Controls.Add(this.panel29);
            this.panel15.Controls.Add(this.panel27);
            this.panel15.Controls.Add(this.button15);
            this.panel15.Location = new System.Drawing.Point(670, 224);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(214, 153);
            this.panel15.TabIndex = 57;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel31.Controls.Add(this.panel32);
            this.panel31.Controls.Add(this.label12);
            this.panel31.Location = new System.Drawing.Point(13, 68);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(187, 24);
            this.panel31.TabIndex = 60;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel32.Location = new System.Drawing.Point(-1, 31);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(187, 24);
            this.panel32.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(2, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Parts Sales:";
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Controls.Add(this.label10);
            this.panel29.Location = new System.Drawing.Point(13, 40);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(187, 24);
            this.panel29.TabIndex = 57;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel30.Location = new System.Drawing.Point(-1, 31);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(187, 24);
            this.panel30.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(2, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Motor Cycle Sales:";
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Controls.Add(this.label13);
            this.panel27.Location = new System.Drawing.Point(13, 12);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(187, 24);
            this.panel27.TabIndex = 59;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel28.Location = new System.Drawing.Point(-1, 31);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(187, 24);
            this.panel28.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(2, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "Service Sales:";
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button15.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button15.Location = new System.Drawing.Point(34, 101);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(150, 36);
            this.button15.TabIndex = 58;
            this.button15.Text = "Log Out";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.groupBoxSales);
            this.panel6.ForeColor = System.Drawing.Color.PaleGreen;
            this.panel6.Location = new System.Drawing.Point(4, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 170);
            this.panel6.TabIndex = 59;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.groupBoxInventory);
            this.panel5.Location = new System.Drawing.Point(171, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 170);
            this.panel5.TabIndex = 60;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(15, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(125, 24);
            this.panel7.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(15, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "PURCHASE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.groupBoxStock);
            this.panel1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Location = new System.Drawing.Point(338, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 170);
            this.panel1.TabIndex = 61;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(15, 16);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(125, 24);
            this.panel10.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(28, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "STOCK";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel14.Controls.Add(this.groupBoxSalesReport);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Location = new System.Drawing.Point(504, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(160, 170);
            this.panel14.TabIndex = 62;
            // 
            // groupBoxSalesReport
            // 
            this.groupBoxSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSalesReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBoxSalesReport.Controls.Add(this.button11);
            this.groupBoxSalesReport.Controls.Add(this.button7);
            this.groupBoxSalesReport.Controls.Add(this.button5);
            this.groupBoxSalesReport.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSalesReport.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxSalesReport.Location = new System.Drawing.Point(15, 46);
            this.groupBoxSalesReport.Name = "groupBoxSalesReport";
            this.groupBoxSalesReport.Size = new System.Drawing.Size(125, 110);
            this.groupBoxSalesReport.TabIndex = 53;
            this.groupBoxSalesReport.TabStop = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.label11);
            this.panel16.Location = new System.Drawing.Point(15, 16);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(125, 24);
            this.panel16.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "REPORT (Sale)";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.groupBoxExpences);
            this.panel8.Location = new System.Drawing.Point(4, 208);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 169);
            this.panel8.TabIndex = 63;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.label14);
            this.panel17.Location = new System.Drawing.Point(16, 16);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(125, 24);
            this.panel17.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Location = new System.Drawing.Point(19, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "EXPENCES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.groupBoxPurchase);
            this.panel2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Location = new System.Drawing.Point(171, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 169);
            this.panel2.TabIndex = 64;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label15);
            this.panel11.Location = new System.Drawing.Point(15, 16);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(125, 24);
            this.panel11.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label15.Location = new System.Drawing.Point(3, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "REPORT (Inv)";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.groupBoxBank);
            this.panel12.Location = new System.Drawing.Point(338, 208);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(160, 169);
            this.panel12.TabIndex = 65;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.label16);
            this.panel13.Location = new System.Drawing.Point(15, 16);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(125, 24);
            this.panel13.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label16.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label16.Location = new System.Drawing.Point(30, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "BANK";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.groupBoxDue);
            this.panel18.Location = new System.Drawing.Point(504, 208);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(160, 169);
            this.panel18.TabIndex = 66;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.label17);
            this.panel19.Location = new System.Drawing.Point(15, 16);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(125, 24);
            this.panel19.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label17.Location = new System.Drawing.Point(39, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "DUE";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(890, 381);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDue.ResumeLayout(false);
            this.groupBoxSales.ResumeLayout(false);
            this.groupBoxStock.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBoxInventory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.groupBoxBank.ResumeLayout(false);
            this.groupBoxPurchase.ResumeLayout(false);
            this.groupBoxExpences.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.groupBoxSalesReport.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void load_model()
        {
            int num;
            string query = "SELECT sale_price,wholesale_price,distributor_price,partsid FROM firoz_center.tbl_parts_info;";
            List<string>[] listArray = new List<string>[4];
            for (num = 0; num < 4; num++)
            {
                listArray[num] = new List<string>();
            }
            listArray = this.dbc.Select(4L, query);
            for (num = 0; num < listArray[0].Count; num++)
            {
                int toRound = int.Parse(listArray[0].ElementAt<string>(num));
                int num3 = int.Parse(listArray[1].ElementAt<string>(num));
                int num4 = int.Parse(listArray[2].ElementAt<string>(num));
                int num5 = int.Parse(listArray[3].ElementAt<string>(num));
                toRound = this.RoundUp(toRound);
                num3 = this.RoundUp(num3);
                num4 = this.RoundUp(num4);
                string str2 = string.Concat(new object[] { "UPDATE firoz_center.tbl_parts_info set sale_price='", toRound, "',wholesale_price='", num3, "',distributor_price='", num4, "' where partsId='", num5, "';" });
                this.dbc.Update(str2);
            }
        }

        private void loadExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReadExcel().Show();
        }

        private void lonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeLoan().Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void monthlyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new TranscationMonthly().Show();
        }

        private void motorCycleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockMotorCycleDetails().Show();
        }

        private void motorCycleStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockReportMotorCycleMonthly().Show();
        }

        private void motorCycleSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportPurchaseSummary().Show();
        }

        private void motorCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewVehicle().Show();
        }

        private void motorCycleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ChangeMotorCyclePrice().Show();
        }

        private void motorCycleToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            new DuePaymentMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            new DueReport("MotorCycle").Show();
        }

        private void motorCycleToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            new EditPurchaseMotorCycle("Delete").Show();
        }

        private void motorCycleToolStripMenuItem14_Click(object sender, EventArgs e)
        {
        }

        private void motorCycleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EditPurchaseMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            new ReportMonthlyPurchaseMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new ReportMonthlyPurchaseMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            new UpdateMotorCycleName().Show();
        }

        private void motorCycleToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            new ReportMonthlySalesMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new ReportMonthlySalesMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            new SearchMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new PrintSaleMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem8_Click(object sender, EventArgs e)
        {
        }

        private void motorCycleToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            new UpdateSaleMotorCycle().Show();
        }

        private void motorCycleToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            new EditPurchaseMotorCycle("").Show();
        }

        private void motorCycleToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            new DuePaymentEditMotorCycle().Show();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DueReportName("Parts").Show();
        }

        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DuePaymentReport().Show();
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewEmployee().Show();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new NewSaleService().Show();
        }

        private void newToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new NewBankTranscation().Show();
        }

        private void newToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new NewPartyTranscation().Show();
        }

        private void newToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new NewExpences().Show();
        }

        private void newToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            NewOrder order = new NewOrder();
            order.Show();
            order.load_data();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void partsStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockPartsReport().Show();
        }

        private void partsStockReportWithPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportPartsWithPrice().Show();
        }

        private void partsSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportSalesPartsDaily().Show();
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewPurchaseParts().Show();
        }

        private void partsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new NewSalesParts().Show();
        }

        private void partsToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            new PrintSaleParts().Show();
        }

        private void partsToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            new StockParts().Show();
        }

        private void partsToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            new DuePaymentParts().Show();
        }

        private void partsToolStripMenuItem11_Click_2(object sender, EventArgs e)
        {
            new DuePaymentEditParts().Show();
        }

        private void partsToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            new EditPurchaseParts("").Show();
        }

        private void partsToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            new DueReport("Parts").Show();
        }

        private void partsToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            new EditPurchaseParts("Delete").Show();
        }

        private void partsToolStripMenuItem16_Click(object sender, EventArgs e)
        {
        }

        private void partsToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            new DeleteParts().Show();
        }

        private void partsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AddNewParts().Show();
        }

        private void partsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new ChangePartsPrice().Show();
        }

        private void partsToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new EditPurchaseParts().Show();
        }

        private void partsToolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            new EditPurchaseParts().Show();
        }

        private void partsToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            new ReportMonthlyPurchaseParts().Show();
        }

        private void partsToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new ReportMonthlyPurchaseParts().Show();
        }

        private void partsToolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            new EditPartsName().Show();
        }

        private void partsToolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            new ReportMonthlySalesParts().Show();
        }

        private void partsToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new ReportMonthlySalesParts().Show();
        }

        private void partsToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            new SearchParts().Show();
        }

        private void partsToolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }

        private void partsToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            new EditSaleParts().Show();
        }

        private void partyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewParty().Show();
        }

        private void partyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void petiCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewPettyCashDeposite().Show();
        }

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostOrder order = new PostOrder();
            order.Show();
            order.load_status();
        }

        private void priceUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePartsPrice().Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PrintSalary().Show();
        }

        private void profitLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LossProfitAccount().Show();
        }

        private void Receive(object sender, EventArgs e)
        {
            new DueReport("MotorCycle").Show();
        }

        private void receiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DueReceiveReport("Parts").Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateCustomer().Show();
        }

        private void reportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ReportMonthlySaleService().Show();
        }

        private void reportToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new ReportBankTranscation().Show();
        }

        private void reportToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new ReportPartyTranscation().Show();
        }

        private void reportToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new DueReport("MotorCycle").Show();
        }

        private void reportToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new EmployeeReport().Show();
        }

        private void reportToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new ReportExpences().Show();
        }

        /*
        private void create_db()
        {
            string strConnection = "CREATE DATABASE IF NOT EXISTS `birthdid`;";
            string connectionString;
            connectionString = "SERVER=localhost;UID=root;PASSWORD=101proof;port=3306;";

            MySqlConnection conDatabase = new MySqlConnection(connectionString);
            MySqlCommand cmdDatabase = new MySqlCommand(strConnection, conDatabase);

            conDatabase.Open();

            cmdDatabase.ExecuteNonQuery();
            conDatabase.Close();

            string sql = "CREATE TABLE `tbl_info` (" +
                         "`id` int(10) unsigned NOT NULL AUTO_INCREMENT," +
                         "`name` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`fname` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`mname` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`birth_place` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`educational_info` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`profession` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`up_sheba` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`birth_id` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`date_of_birth` datetime NOT NULL," +
                         "`n_id` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`word_no` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`address` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`maritial_status` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`mobile` varchar(45) CHARACTER SET utf8 NOT NULL," +
                         "`description` varchar(100) CHARACTER SET utf8 NOT NULL," +
                         "`date_entry` datetime NOT NULL," +
                         "`user_id` int(10) unsigned NOT NULL," +
                         "PRIMARY KEY (`id`)" +
                         ") ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;" +
                         "CREATE TABLE `tbl_txt` (" +
                         "`name` varchar(200) NOT NULL," +
                         "`address` varchar(200) NOT NULL," +
                         "`email` varchar(200) NOT NULL," +
                         "`phone` varchar(200) NOT NULL," +
                         "`id` int(10) unsigned NOT NULL AUTO_INCREMENT," +
                         "PRIMARY KEY (`id`)" +
                         ") ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;" +
                         "CREATE TABLE `tbl_user` (" +
                         "`user_id` int(10) unsigned NOT NULL AUTO_INCREMENT," +
                         "`name` varchar(100) NOT NULL," +
                         "`pass` varchar(45) NOT NULL," +
                         "`full_name` varchar(100) NOT NULL," +
                         "`status` varchar(45) NOT NULL," +
                         "`access_level` varchar(45) NOT NULL," +
                         "`tab1` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab2` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab3` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab4` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab5` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab6` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab7` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab8` varchar(45) NOT NULL DEFAULT 'False'," +
                         "`tab9` varchar(45) NOT NULL DEFAULT 'False'," +                       
                         "PRIMARY KEY (`user_id`)" +
                         ") ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;" +
                         "INSERT INTO `birthdid`.`tbl_user` (`user_id`,`name`,`pass`,`full_name`,`status`) VALUES " +
                         "(1,'admin','101proof','Admin','1');";

            dbc.Insert(sql);
        }
        */

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DBConnect().RestoreDatabase(@"C:\Program Files (x86)\MySQL\MySQL Server 5.1\bin\mysqldump.exe", "firoz_center");
        }

        private int RoundUp(int toRound)
        {
            return ((10 - (toRound % 10)) + toRound);
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeSalary().Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewService().Show();
        }

        private void serviceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EditPriceService().Show();
        }

        private void serviceToolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void serviceToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new DueReport("Service").Show();
        }

        private void serviceToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new ChangeServicePrice().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label5.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;
            string str = string.Format("{0:hh-mm-ss}", now);
            this.label5.Text = "Time: " + str;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void transcationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new StockReportPartsTranscation().Show();
        }

        private void transcationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new StockReportMotorCycleTranscation().Show();
        }

        private void updateMotorCycleStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateMotorCycleStatus().Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewSalesMotorCycle().Show();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewPurchaseMotorCycle().Show();
        }

        private void priceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartsPriceLIst PPL = new PartsPriceLIst();
            PPL.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerContactNumber().Show();
        }

        private void partsPartyPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMonthlySalesPartyPrice RMSPP = new ReportMonthlySalesPartyPrice();
            RMSPP.Show();
        }

        private void dueServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DueService DS = new DueService();
            DS.Show();
        }

        private void servicingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportServicing RS = new ReportServicing();
            RS.Show();
        }

        private void summeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportInventorySummery RIS = new ReportInventorySummery();
            RIS.Show();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
        }

        private void userToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditAccessLevel EAL = new EditAccessLevel();
            EAL.Show();
        }

        private void motorcyclePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportMotorcyclePrice RMP = new ReportMotorcyclePrice();
            RMP.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReportMotorcycleMonthlyModelOnly SRMSMCMO = new StockReportMotorcycleMonthlyModelOnly();
            SRMSMCMO.Show();
        }

        private void contactNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CustomerContactNumber().Show();
        }

        private void invoiceNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdatePurchaseInvoice().Show();
        }
    }
}

