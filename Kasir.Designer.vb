<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMenuType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboJuiceMenu = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RBtunai = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RBqris = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtCustName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPurchaseAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RBsmall = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RBmedium = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RBlarge = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCash = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtChange = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DGVPembelian = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nama_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DGVPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CASHIER"
        '
        'cboMenuType
        '
        Me.cboMenuType.BackColor = System.Drawing.Color.Transparent
        Me.cboMenuType.BorderRadius = 7
        Me.cboMenuType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMenuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMenuType.DropDownWidth = 160
        Me.cboMenuType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboMenuType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboMenuType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboMenuType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboMenuType.ItemHeight = 25
        Me.cboMenuType.Location = New System.Drawing.Point(162, 136)
        Me.cboMenuType.Name = "cboMenuType"
        Me.cboMenuType.Size = New System.Drawing.Size(222, 31)
        Me.cboMenuType.TabIndex = 8
        '
        'cboJuiceMenu
        '
        Me.cboJuiceMenu.BackColor = System.Drawing.Color.Transparent
        Me.cboJuiceMenu.BorderRadius = 8
        Me.cboJuiceMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboJuiceMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJuiceMenu.DropDownWidth = 160
        Me.cboJuiceMenu.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboJuiceMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboJuiceMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboJuiceMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboJuiceMenu.ItemHeight = 25
        Me.cboJuiceMenu.Location = New System.Drawing.Point(162, 174)
        Me.cboJuiceMenu.Name = "cboJuiceMenu"
        Me.cboJuiceMenu.Size = New System.Drawing.Size(222, 31)
        Me.cboJuiceMenu.TabIndex = 9
        '
        'RBtunai
        '
        Me.RBtunai.AutoSize = True
        Me.RBtunai.BackColor = System.Drawing.Color.Transparent
        Me.RBtunai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBtunai.CheckedState.BorderThickness = 0
        Me.RBtunai.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBtunai.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBtunai.CheckedState.InnerOffset = -4
        Me.RBtunai.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtunai.Location = New System.Drawing.Point(195, 268)
        Me.RBtunai.Name = "RBtunai"
        Me.RBtunai.Size = New System.Drawing.Size(64, 27)
        Me.RBtunai.TabIndex = 10
        Me.RBtunai.Text = "Tunai"
        Me.RBtunai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBtunai.UncheckedState.BorderThickness = 2
        Me.RBtunai.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBtunai.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RBtunai.UseVisualStyleBackColor = False
        '
        'RBqris
        '
        Me.RBqris.AutoSize = True
        Me.RBqris.BackColor = System.Drawing.Color.Transparent
        Me.RBqris.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBqris.CheckedState.BorderThickness = 0
        Me.RBqris.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBqris.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBqris.CheckedState.InnerOffset = -4
        Me.RBqris.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBqris.Location = New System.Drawing.Point(279, 268)
        Me.RBqris.Name = "RBqris"
        Me.RBqris.Size = New System.Drawing.Size(54, 27)
        Me.RBqris.TabIndex = 11
        Me.RBqris.Text = "Qris"
        Me.RBqris.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBqris.UncheckedState.BorderThickness = 2
        Me.RBqris.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBqris.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RBqris.UseVisualStyleBackColor = False
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.Transparent
        Me.txtCustName.BorderRadius = 7
        Me.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustName.DefaultText = ""
        Me.txtCustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustName.Location = New System.Drawing.Point(162, 98)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustName.PlaceholderText = ""
        Me.txtCustName.SelectedText = ""
        Me.txtCustName.Size = New System.Drawing.Size(222, 32)
        Me.txtCustName.TabIndex = 12
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.BackColor = System.Drawing.Color.Transparent
        Me.txtPurchaseAmount.BorderRadius = 7
        Me.txtPurchaseAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurchaseAmount.DefaultText = ""
        Me.txtPurchaseAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPurchaseAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPurchaseAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPurchaseAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPurchaseAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPurchaseAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPurchaseAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(162, 211)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPurchaseAmount.PlaceholderText = ""
        Me.txtPurchaseAmount.SelectedText = ""
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(222, 25)
        Me.txtPurchaseAmount.TabIndex = 13
        '
        'RBsmall
        '
        Me.RBsmall.AutoSize = True
        Me.RBsmall.BackColor = System.Drawing.Color.Transparent
        Me.RBsmall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBsmall.CheckedState.BorderThickness = 0
        Me.RBsmall.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBsmall.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBsmall.CheckedState.InnerOffset = -4
        Me.RBsmall.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBsmall.Location = New System.Drawing.Point(171, 240)
        Me.RBsmall.Name = "RBsmall"
        Me.RBsmall.Size = New System.Drawing.Size(63, 27)
        Me.RBsmall.TabIndex = 14
        Me.RBsmall.Text = "Small"
        Me.RBsmall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBsmall.UncheckedState.BorderThickness = 2
        Me.RBsmall.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBsmall.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RBsmall.UseVisualStyleBackColor = False
        '
        'RBmedium
        '
        Me.RBmedium.AutoSize = True
        Me.RBmedium.BackColor = System.Drawing.Color.Transparent
        Me.RBmedium.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBmedium.CheckedState.BorderThickness = 0
        Me.RBmedium.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBmedium.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBmedium.CheckedState.InnerOffset = -4
        Me.RBmedium.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmedium.Location = New System.Drawing.Point(234, 240)
        Me.RBmedium.Name = "RBmedium"
        Me.RBmedium.Size = New System.Drawing.Size(78, 27)
        Me.RBmedium.TabIndex = 15
        Me.RBmedium.Text = "Medium"
        Me.RBmedium.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBmedium.UncheckedState.BorderThickness = 2
        Me.RBmedium.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBmedium.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RBmedium.UseVisualStyleBackColor = False
        '
        'RBlarge
        '
        Me.RBlarge.AutoSize = True
        Me.RBlarge.BackColor = System.Drawing.Color.Transparent
        Me.RBlarge.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBlarge.CheckedState.BorderThickness = 0
        Me.RBlarge.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RBlarge.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RBlarge.CheckedState.InnerOffset = -4
        Me.RBlarge.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBlarge.Location = New System.Drawing.Point(311, 240)
        Me.RBlarge.Name = "RBlarge"
        Me.RBlarge.Size = New System.Drawing.Size(63, 27)
        Me.RBlarge.TabIndex = 16
        Me.RBlarge.Text = "Large"
        Me.RBlarge.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RBlarge.UncheckedState.BorderThickness = 2
        Me.RBlarge.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RBlarge.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RBlarge.UseVisualStyleBackColor = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(5, 136)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(147, 25)
        Me.Guna2HtmlLabel2.TabIndex = 18
        Me.Guna2HtmlLabel2.Text = "Choose menu type"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(5, 174)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(102, 25)
        Me.Guna2HtmlLabel3.TabIndex = 19
        Me.Guna2HtmlLabel3.Text = "Choose juice"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(5, 208)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(140, 25)
        Me.Guna2HtmlLabel4.TabIndex = 20
        Me.Guna2HtmlLabel4.Text = "Purchase amount"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(6, 238)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(76, 25)
        Me.Guna2HtmlLabel5.TabIndex = 21
        Me.Guna2HtmlLabel5.Text = "Size type"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(5, 269)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(137, 25)
        Me.Guna2HtmlLabel6.TabIndex = 22
        Me.Guna2HtmlLabel6.Text = "Payment method"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.BorderRadius = 7
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(132, 349)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.Size = New System.Drawing.Size(252, 25)
        Me.txtTotal.TabIndex = 23
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.Transparent
        Me.txtCash.BorderRadius = 7
        Me.txtCash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCash.DefaultText = ""
        Me.txtCash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.Location = New System.Drawing.Point(132, 380)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.PlaceholderText = ""
        Me.txtCash.SelectedText = ""
        Me.txtCash.Size = New System.Drawing.Size(252, 25)
        Me.txtCash.TabIndex = 24
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.Transparent
        Me.txtChange.BorderRadius = 7
        Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChange.DefaultText = ""
        Me.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.Location = New System.Drawing.Point(132, 411)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.PlaceholderText = ""
        Me.txtChange.SelectedText = ""
        Me.txtChange.Size = New System.Drawing.Size(252, 25)
        Me.txtChange.TabIndex = 25
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderColor = System.Drawing.Color.Bisque
        Me.btnAdd.BorderRadius = 7
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(72, 306)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 27)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BorderColor = System.Drawing.Color.Bisque
        Me.btnRemove.BorderRadius = 7
        Me.btnRemove.BorderThickness = 1
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(195, 306)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(103, 27)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "Remove"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(6, 347)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(119, 25)
        Me.Guna2HtmlLabel7.TabIndex = 28
        Me.Guna2HtmlLabel7.Text = "Total payment"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(6, 378)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(40, 25)
        Me.Guna2HtmlLabel8.TabIndex = 29
        Me.Guna2HtmlLabel8.Text = "Cash"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(6, 407)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(60, 25)
        Me.Guna2HtmlLabel9.TabIndex = 30
        Me.Guna2HtmlLabel9.Text = "Change"
        '
        'DGVPembelian
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPembelian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPembelian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPembelian.ColumnHeadersHeight = 28
        Me.DGVPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_item, Me.harga, Me.jumlah, Me.subtotal})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPembelian.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPembelian.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.Location = New System.Drawing.Point(407, 72)
        Me.DGVPembelian.Name = "DGVPembelian"
        Me.DGVPembelian.RowHeadersVisible = False
        Me.DGVPembelian.RowHeadersWidth = 62
        Me.DGVPembelian.Size = New System.Drawing.Size(369, 321)
        Me.DGVPembelian.TabIndex = 32
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVPembelian.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVPembelian.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVPembelian.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPembelian.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPembelian.ThemeStyle.HeaderStyle.Height = 28
        Me.DGVPembelian.ThemeStyle.ReadOnly = False
        Me.DGVPembelian.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPembelian.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVPembelian.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPembelian.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.RowsStyle.Height = 22
        Me.DGVPembelian.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPembelian.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'nama_item
        '
        Me.nama_item.HeaderText = "Nama Barang"
        Me.nama_item.MinimumWidth = 8
        Me.nama_item.Name = "nama_item"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 8
        Me.jumlah.Name = "jumlah"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Total"
        Me.subtotal.MinimumWidth = 8
        Me.subtotal.Name = "subtotal"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderColor = System.Drawing.Color.Bisque
        Me.btnPrint.BorderRadius = 7
        Me.btnPrint.BorderThickness = 1
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(407, 411)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 27)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "Print"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderColor = System.Drawing.Color.Bisque
        Me.btnExit.BorderRadius = 7
        Me.btnExit.BorderThickness = 1
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.DarkSeaGreen
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(516, 411)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 27)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 39)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Hello,"
        '
        'txtUser
        '
        Me.txtUser.AutoSize = True
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BorderThickness = 0
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.DefaultText = ""
        Me.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Font = New System.Drawing.Font("Sitka Small", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Location = New System.Drawing.Point(264, 4)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PlaceholderText = ""
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(120, 49)
        Me.txtUser.TabIndex = 36
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(5, 98)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(140, 25)
        Me.Guna2HtmlLabel1.TabIndex = 17
        Me.Guna2HtmlLabel1.Text = "Customer's name"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(6, 61)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(61, 25)
        Me.Guna2HtmlLabel10.TabIndex = 37
        Me.Guna2HtmlLabel10.Text = "Invoice"
        Me.Guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoice
        '
        Me.txtInvoice.BackColor = System.Drawing.Color.Transparent
        Me.txtInvoice.BorderRadius = 7
        Me.txtInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInvoice.DefaultText = ""
        Me.txtInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInvoice.Location = New System.Drawing.Point(162, 61)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInvoice.PlaceholderText = ""
        Me.txtInvoice.ReadOnly = True
        Me.txtInvoice.SelectedText = ""
        Me.txtInvoice.Size = New System.Drawing.Size(222, 32)
        Me.txtInvoice.TabIndex = 38
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UAS_ABRYZAPUT_B.My.Resources.Resources.razka_raja_juice_buah2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DGVPembelian)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.RBlarge)
        Me.Controls.Add(Me.RBmedium)
        Me.Controls.Add(Me.RBsmall)
        Me.Controls.Add(Me.txtPurchaseAmount)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.RBqris)
        Me.Controls.Add(Me.RBtunai)
        Me.Controls.Add(Me.cboJuiceMenu)
        Me.Controls.Add(Me.cboMenuType)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Kasir"
        Me.Text = "Kasir"
        CType(Me.DGVPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboMenuType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboJuiceMenu As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RBtunai As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RBqris As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtCustName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPurchaseAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RBsmall As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RBmedium As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RBlarge As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCash As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtChange As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DGVPembelian As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents nama_item As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtInvoice As Guna.UI2.WinForms.Guna2TextBox
End Class
