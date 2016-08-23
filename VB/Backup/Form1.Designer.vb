Namespace DotNetNote
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.metroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
			Me.metroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
			Me.metroToolbar1 = New DevComponents.DotNetBar.Metro.MetroToolbar()
			Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem10 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem13 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem14 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem15 = New DevComponents.DotNetBar.ButtonItem()
			Me.metroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
			Me.metroToolbar3 = New DevComponents.DotNetBar.Metro.MetroToolbar()
			Me.buttonItem27 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem28 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem29 = New DevComponents.DotNetBar.ButtonItem()
			Me.switchButtonItem1 = New DevComponents.DotNetBar.SwitchButtonItem()
			Me.metroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
			Me.metroToolbar2 = New DevComponents.DotNetBar.Metro.MetroToolbar()
			Me.buttonItem22 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem23 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem24 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem25 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem26 = New DevComponents.DotNetBar.ButtonItem()
			Me.metroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
			Me.metroTabItem2 = New DevComponents.DotNetBar.Metro.MetroTabItem()
			Me.metroTabItem3 = New DevComponents.DotNetBar.Metro.MetroTabItem()
			Me.buttonItem16 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem17 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem18 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem19 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem20 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem21 = New DevComponents.DotNetBar.ButtonItem()
			Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
			Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
			Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
			Me.superTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
			Me.richTextBoxEx1 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
			Me.metroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
			Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
			Me.metroShell1.SuspendLayout()
			Me.metroTabPanel1.SuspendLayout()
			Me.metroTabPanel3.SuspendLayout()
			Me.metroTabPanel2.SuspendLayout()
			CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.superTabControl1.SuspendLayout()
			Me.superTabControlPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' metroShell1
			' 
			Me.metroShell1.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroShell1.CaptionVisible = True
			Me.metroShell1.Controls.Add(Me.metroTabPanel1)
			Me.metroShell1.Controls.Add(Me.metroTabPanel3)
			Me.metroShell1.Controls.Add(Me.metroTabPanel2)
			Me.metroShell1.Dock = System.Windows.Forms.DockStyle.Top
			Me.metroShell1.ForeColor = System.Drawing.Color.Black
			Me.metroShell1.HelpButtonText = Nothing
			Me.metroShell1.HelpButtonVisible = False
			Me.metroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.metroTabItem1, Me.metroTabItem2, Me.metroTabItem3, Me.buttonItem16, Me.buttonItem17, Me.buttonItem18, Me.buttonItem19, Me.buttonItem20, Me.buttonItem21})
			Me.metroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7F)
			Me.metroShell1.Location = New System.Drawing.Point(0, 1)
			Me.metroShell1.Name = "metroShell1"
			Me.metroShell1.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
			Me.metroShell1.SettingsButtonVisible = False
			Me.metroShell1.ShowIcon = False
			Me.metroShell1.Size = New System.Drawing.Size(779, 107)
			Me.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
			Me.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
			Me.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
			Me.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
			Me.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
			Me.metroShell1.SystemText.QatDialogAddButton = "&Add >>"
			Me.metroShell1.SystemText.QatDialogCancelButton = "Cancel"
			Me.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
			Me.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
			Me.metroShell1.SystemText.QatDialogOkButton = "OK"
			Me.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
			Me.metroShell1.SystemText.QatDialogRemoveButton = "&Remove"
			Me.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
			Me.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
			Me.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
			Me.metroShell1.TabIndex = 0
			Me.metroShell1.TabStripFont = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			' 
			' metroTabPanel1
			' 
			Me.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
			Me.metroTabPanel1.Controls.Add(Me.metroToolbar1)
			Me.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.metroTabPanel1.Location = New System.Drawing.Point(1, 67)
			Me.metroTabPanel1.Name = "metroTabPanel1"
			Me.metroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 3)
			Me.metroTabPanel1.Size = New System.Drawing.Size(778, 40)
			' 
			' 
			' 
			Me.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTabPanel1.TabIndex = 1
			' 
			' metroToolbar1
			' 
			Me.metroToolbar1.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.metroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroToolbar1.ContainerControlProcessDialogKey = True
			Me.metroToolbar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.metroToolbar1.DragDropSupport = True
			Me.metroToolbar1.ExpandButtonVisible = False
			Me.metroToolbar1.Font = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroToolbar1.ForeColor = System.Drawing.Color.Black
			Me.metroToolbar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.buttonItem5, Me.buttonItem6, Me.buttonItem7, Me.buttonItem8, Me.buttonItem9, Me.buttonItem1, Me.buttonItem10, Me.buttonItem11, Me.buttonItem12, Me.buttonItem13, Me.buttonItem14, Me.buttonItem15})
			Me.metroToolbar1.ItemSpacing = 2
			Me.metroToolbar1.Location = New System.Drawing.Point(3, 4)
			Me.metroToolbar1.Name = "metroToolbar1"
			Me.metroToolbar1.Size = New System.Drawing.Size(772, 34)
			Me.metroToolbar1.TabIndex = 0
			Me.metroToolbar1.Text = "metroToolbar1"
			' 
			' buttonItem2
			' 
			Me.buttonItem2.Image = My.Resources.BoldIcon
			Me.buttonItem2.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem2.Name = "buttonItem2"
			Me.buttonItem2.Text = "Bold"
			' 
			' buttonItem3
			' 
			Me.buttonItem3.Image = My.Resources.ItalicIcon
			Me.buttonItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem3.Name = "buttonItem3"
			Me.buttonItem3.Text = "Italic"
			' 
			' buttonItem4
			' 
			Me.buttonItem4.Image = My.Resources.UnderlineIcon
			Me.buttonItem4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem4.Name = "buttonItem4"
			Me.buttonItem4.Text = "Underline"
			' 
			' buttonItem5
			' 
			Me.buttonItem5.Image = My.Resources.StrikeIcon
			Me.buttonItem5.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem5.Name = "buttonItem5"
			Me.buttonItem5.Text = "Strike"
			' 
			' buttonItem6
			' 
			Me.buttonItem6.Image = My.Resources.TextColorIcon
			Me.buttonItem6.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem6.Name = "buttonItem6"
			Me.buttonItem6.Text = "Text Color"
			' 
			' buttonItem7
			' 
			Me.buttonItem7.Image = My.Resources.TextHighlightIcon
			Me.buttonItem7.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem7.Name = "buttonItem7"
			Me.buttonItem7.Text = "Highlight"
			' 
			' buttonItem8
			' 
			Me.buttonItem8.Image = My.Resources.BullletIcon
			Me.buttonItem8.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem8.Name = "buttonItem8"
			Me.buttonItem8.Text = "Bullets"
			' 
			' buttonItem9
			' 
			Me.buttonItem9.Image = My.Resources.BullletNumberIcon
			Me.buttonItem9.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem9.Name = "buttonItem9"
			Me.buttonItem9.Text = "Numbers"
			' 
			' buttonItem1
			' 
			Me.buttonItem1.Image = My.Resources.OutdentIcon
			Me.buttonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem1.Name = "buttonItem1"
			Me.buttonItem1.Text = "Outdent"
			' 
			' buttonItem10
			' 
			Me.buttonItem10.Image = My.Resources.IndentIcon
			Me.buttonItem10.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem10.Name = "buttonItem10"
			Me.buttonItem10.Text = "Indent"
			' 
			' buttonItem11
			' 
			Me.buttonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem11.Image = My.Resources.TextStylesIcon
			Me.buttonItem11.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem11.Name = "buttonItem11"
			Me.buttonItem11.Text = "Styles"
			' 
			' buttonItem12
			' 
			Me.buttonItem12.Image = My.Resources.CheckMarkIcon
			Me.buttonItem12.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem12.Name = "buttonItem12"
			Me.buttonItem12.Text = "Checks"
			' 
			' buttonItem13
			' 
			Me.buttonItem13.Image = My.Resources.StarIcon
			Me.buttonItem13.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem13.Name = "buttonItem13"
			Me.buttonItem13.Text = "Stars"
			' 
			' buttonItem14
			' 
			Me.buttonItem14.Image = My.Resources.HelpIcon
			Me.buttonItem14.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem14.Name = "buttonItem14"
			Me.buttonItem14.Text = "Help"
			' 
			' buttonItem15
			' 
			Me.buttonItem15.Image = My.Resources.TagIcon
			Me.buttonItem15.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem15.Name = "buttonItem15"
			Me.buttonItem15.Text = "Tags"
			' 
			' metroTabPanel3
			' 
			Me.metroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
			Me.metroTabPanel3.Controls.Add(Me.metroToolbar3)
			Me.metroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.metroTabPanel3.Location = New System.Drawing.Point(1, 67)
			Me.metroTabPanel3.Name = "metroTabPanel3"
			Me.metroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 3)
			Me.metroTabPanel3.Size = New System.Drawing.Size(778, 40)
			' 
			' 
			' 
			Me.metroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTabPanel3.TabIndex = 3
			Me.metroTabPanel3.Visible = False
			' 
			' metroToolbar3
			' 
			Me.metroToolbar3.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.metroToolbar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroToolbar3.ContainerControlProcessDialogKey = True
			Me.metroToolbar3.Dock = System.Windows.Forms.DockStyle.Top
			Me.metroToolbar3.DragDropSupport = True
			Me.metroToolbar3.ExpandButtonVisible = False
			Me.metroToolbar3.Font = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroToolbar3.ForeColor = System.Drawing.Color.Black
			Me.metroToolbar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem27, Me.buttonItem28, Me.buttonItem29, Me.switchButtonItem1})
			Me.metroToolbar3.ItemSpacing = 2
			Me.metroToolbar3.Location = New System.Drawing.Point(3, 4)
			Me.metroToolbar3.Name = "metroToolbar3"
			Me.metroToolbar3.Size = New System.Drawing.Size(772, 34)
			Me.metroToolbar3.TabIndex = 2
			Me.metroToolbar3.Text = "metroToolbar3"
			' 
			' buttonItem27
			' 
			Me.buttonItem27.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem27.Image = My.Resources.DocIcon
			Me.buttonItem27.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem27.Name = "buttonItem27"
			Me.buttonItem27.Text = "100%"
			' 
			' buttonItem28
			' 
			Me.buttonItem28.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem28.Image = My.Resources.PageWidthIcon
			Me.buttonItem28.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem28.Name = "buttonItem28"
			Me.buttonItem28.Text = "Page Width"
			' 
			' buttonItem29
			' 
			Me.buttonItem29.BeginGroup = True
			Me.buttonItem29.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem29.Image = My.Resources.PageColorIcon
			Me.buttonItem29.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem29.Name = "buttonItem29"
			Me.buttonItem29.Text = "Page Color"
			' 
			' switchButtonItem1
			' 
			Me.switchButtonItem1.BeginGroup = True
			Me.switchButtonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.switchButtonItem1.Name = "switchButtonItem1"
			Me.switchButtonItem1.Text = "Spelling"
			Me.switchButtonItem1.TextPadding.Left = 8
			' 
			' metroTabPanel2
			' 
			Me.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
			Me.metroTabPanel2.Controls.Add(Me.metroToolbar2)
			Me.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.metroTabPanel2.Location = New System.Drawing.Point(1, 0)
			Me.metroTabPanel2.Name = "metroTabPanel2"
			Me.metroTabPanel2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 3)
			Me.metroTabPanel2.Size = New System.Drawing.Size(778, 112)
			' 
			' 
			' 
			Me.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTabPanel2.TabIndex = 2
			Me.metroTabPanel2.Visible = False
			' 
			' metroToolbar2
			' 
			Me.metroToolbar2.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.metroToolbar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroToolbar2.ContainerControlProcessDialogKey = True
			Me.metroToolbar2.Dock = System.Windows.Forms.DockStyle.Top
			Me.metroToolbar2.DragDropSupport = True
			Me.metroToolbar2.ExpandButtonVisible = False
			Me.metroToolbar2.Font = New System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroToolbar2.ForeColor = System.Drawing.Color.Black
			Me.metroToolbar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem22, Me.buttonItem23, Me.buttonItem24, Me.buttonItem25, Me.buttonItem26})
			Me.metroToolbar2.ItemSpacing = 2
			Me.metroToolbar2.Location = New System.Drawing.Point(3, 4)
			Me.metroToolbar2.Name = "metroToolbar2"
			Me.metroToolbar2.Size = New System.Drawing.Size(772, 34)
			Me.metroToolbar2.TabIndex = 1
			Me.metroToolbar2.Text = "metroToolbar2"
			' 
			' buttonItem22
			' 
			Me.buttonItem22.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem22.Image = My.Resources.TableIcon
			Me.buttonItem22.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem22.Name = "buttonItem22"
			Me.buttonItem22.Text = "Table"
			' 
			' buttonItem23
			' 
			Me.buttonItem23.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem23.Image = My.Resources.PicturesIcon
			Me.buttonItem23.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem23.Name = "buttonItem23"
			Me.buttonItem23.Text = "Pictures"
			' 
			' buttonItem24
			' 
			Me.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem24.Image = My.Resources.CameraIcon
			Me.buttonItem24.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem24.Name = "buttonItem24"
			Me.buttonItem24.Text = "Camera"
			' 
			' buttonItem25
			' 
			Me.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem25.Image = My.Resources.LinkIcon
			Me.buttonItem25.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem25.Name = "buttonItem25"
			Me.buttonItem25.Text = "Hyperlink"
			' 
			' buttonItem26
			' 
			Me.buttonItem26.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
			Me.buttonItem26.Image = My.Resources.DateIcon
			Me.buttonItem26.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.buttonItem26.Name = "buttonItem26"
			Me.buttonItem26.Text = "Date"
			' 
			' metroTabItem1
			' 
			Me.metroTabItem1.Checked = True
			Me.metroTabItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.metroTabItem1.Name = "metroTabItem1"
			Me.metroTabItem1.Panel = Me.metroTabPanel1
			Me.metroTabItem1.Text = "&HOME"
			' 
			' metroTabItem2
			' 
			Me.metroTabItem2.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.metroTabItem2.Name = "metroTabItem2"
			Me.metroTabItem2.Panel = Me.metroTabPanel2
			Me.metroTabItem2.Text = "&INSERT"
			' 
			' metroTabItem3
			' 
			Me.metroTabItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
			Me.metroTabItem3.Name = "metroTabItem3"
			Me.metroTabItem3.Panel = Me.metroTabPanel3
			Me.metroTabItem3.Text = "&VIEW"
			' 
			' buttonItem16
			' 
			Me.buttonItem16.Image = My.Resources.BackIcon
			Me.buttonItem16.Name = "buttonItem16"
			Me.buttonItem16.Text = "Back"
			' 
			' buttonItem17
			' 
			Me.buttonItem17.Image = My.Resources.SyncIcon
			Me.buttonItem17.Name = "buttonItem17"
			Me.buttonItem17.Text = "Sync"
			' 
			' buttonItem18
			' 
			Me.buttonItem18.Image = My.Resources.UndoIcon
			Me.buttonItem18.Name = "buttonItem18"
			Me.buttonItem18.Text = "Undo"
			' 
			' buttonItem19
			' 
			Me.buttonItem19.Image = My.Resources.RedoIcon
			Me.buttonItem19.Name = "buttonItem19"
			Me.buttonItem19.Text = "Redo"
			' 
			' buttonItem20
			' 
			Me.buttonItem20.Image = My.Resources.SearchIcon
			Me.buttonItem20.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
			Me.buttonItem20.Name = "buttonItem20"
			Me.buttonItem20.Text = "Search"
			' 
			' buttonItem21
			' 
			Me.buttonItem21.Image = My.Resources.AddUserIcon
			Me.buttonItem21.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
			Me.buttonItem21.Name = "buttonItem21"
			Me.buttonItem21.Text = "Add User"
			' 
			' styleManager1
			' 
			Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014
			Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(57)))), (CInt((CByte(123))))))
			' 
			' superTabControl1
			' 
			Me.superTabControl1.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			' 
			' 
			' 
			Me.superTabControl1.ControlBox.CloseBox.Name = ""
			' 
			' 
			' 
			Me.superTabControl1.ControlBox.MenuBox.Name = ""
			Me.superTabControl1.ControlBox.Name = ""
			Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel5)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel4)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel3)
			Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
			Me.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.superTabControl1.ForeColor = System.Drawing.Color.Black
			Me.superTabControl1.Location = New System.Drawing.Point(0, 108)
			Me.superTabControl1.Name = "superTabControl1"
			Me.superTabControl1.ReorderTabsEnabled = True
			Me.superTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.superTabControl1.SelectedTabIndex = 0
			Me.superTabControl1.Size = New System.Drawing.Size(779, 353)
			Me.superTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.superTabControl1.TabIndex = 1
			Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.superTabItem1, Me.superTabItem2, Me.superTabItem3, Me.superTabItem4, Me.superTabItem5})
			Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OfficeMobile2014
			' 
			' superTabControlPanel1
			' 
			Me.superTabControlPanel1.Controls.Add(Me.richTextBoxEx1)
			Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.superTabControlPanel1.Location = New System.Drawing.Point(0, 33)
			Me.superTabControlPanel1.Name = "superTabControlPanel1"
			Me.superTabControlPanel1.Padding = New System.Windows.Forms.Padding(16)
			Me.superTabControlPanel1.Size = New System.Drawing.Size(779, 320)
			Me.superTabControlPanel1.TabIndex = 1
			Me.superTabControlPanel1.TabItem = Me.superTabItem1
			' 
			' superTabItem1
			' 
			Me.superTabItem1.AttachedControl = Me.superTabControlPanel1
			Me.superTabItem1.GlobalItem = False
			Me.superTabItem1.Name = "superTabItem1"
			Me.superTabItem1.Text = "My Notes"
			' 
			' superTabControlPanel5
			' 
			Me.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.superTabControlPanel5.Location = New System.Drawing.Point(0, 0)
			Me.superTabControlPanel5.Name = "superTabControlPanel5"
			Me.superTabControlPanel5.Size = New System.Drawing.Size(779, 353)
			Me.superTabControlPanel5.TabIndex = 0
			Me.superTabControlPanel5.TabItem = Me.superTabItem5
			' 
			' superTabItem5
			' 
			Me.superTabItem5.AttachedControl = Me.superTabControlPanel5
			Me.superTabItem5.GlobalItem = False
			Me.superTabItem5.Name = "superTabItem5"
			Me.superTabItem5.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Coral
			Me.superTabItem5.Text = "New Section 3"
			' 
			' superTabControlPanel4
			' 
			Me.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.superTabControlPanel4.Location = New System.Drawing.Point(0, 0)
			Me.superTabControlPanel4.Name = "superTabControlPanel4"
			Me.superTabControlPanel4.Size = New System.Drawing.Size(779, 353)
			Me.superTabControlPanel4.TabIndex = 0
			Me.superTabControlPanel4.TabItem = Me.superTabItem4
			' 
			' superTabItem4
			' 
			Me.superTabItem4.AttachedControl = Me.superTabControlPanel4
			Me.superTabItem4.GlobalItem = False
			Me.superTabItem4.Name = "superTabItem4"
			Me.superTabItem4.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Green
			Me.superTabItem4.Text = "New Section 2"
			' 
			' superTabControlPanel3
			' 
			Me.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.superTabControlPanel3.Location = New System.Drawing.Point(0, 0)
			Me.superTabControlPanel3.Name = "superTabControlPanel3"
			Me.superTabControlPanel3.Size = New System.Drawing.Size(779, 353)
			Me.superTabControlPanel3.TabIndex = 0
			Me.superTabControlPanel3.TabItem = Me.superTabItem3
			' 
			' superTabItem3
			' 
			Me.superTabItem3.AttachedControl = Me.superTabControlPanel3
			Me.superTabItem3.GlobalItem = False
			Me.superTabItem3.Name = "superTabItem3"
			Me.superTabItem3.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Blue
			Me.superTabItem3.Text = "New Section 1"
			' 
			' superTabControlPanel2
			' 
			Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.superTabControlPanel2.Location = New System.Drawing.Point(0, 0)
			Me.superTabControlPanel2.Name = "superTabControlPanel2"
			Me.superTabControlPanel2.Size = New System.Drawing.Size(779, 353)
			Me.superTabControlPanel2.TabIndex = 0
			Me.superTabControlPanel2.TabItem = Me.superTabItem2
			' 
			' superTabItem2
			' 
			Me.superTabItem2.AttachedControl = Me.superTabControlPanel2
			Me.superTabItem2.GlobalItem = False
			Me.superTabItem2.Name = "superTabItem2"
			Me.superTabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Gold
			Me.superTabItem2.Text = "Test"
			' 
			' richTextBoxEx1
			' 
			' 
			' 
			' 
			Me.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.richTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBoxEx1.Location = New System.Drawing.Point(16, 16)
			Me.richTextBoxEx1.Name = "richTextBoxEx1"
			Me.richTextBoxEx1.Rtf = resources.GetString("richTextBoxEx1.Rtf")
			Me.richTextBoxEx1.Size = New System.Drawing.Size(747, 288)
			Me.richTextBoxEx1.TabIndex = 0
			Me.richTextBoxEx1.Text = resources.GetString("richTextBoxEx1.Text")
'			Me.richTextBoxEx1.LinkClicked += New System.Windows.Forms.LinkClickedEventHandler(Me.richTextBoxEx1_LinkClicked)
			' 
			' metroStatusBar1
			' 
			Me.metroStatusBar1.BackColor = System.Drawing.Color.White
			' 
			' 
			' 
			Me.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroStatusBar1.ContainerControlProcessDialogKey = True
			Me.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.metroStatusBar1.DragDropSupport = True
			Me.metroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroStatusBar1.ForeColor = System.Drawing.Color.Black
			Me.metroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelItem1})
			Me.metroStatusBar1.Location = New System.Drawing.Point(0, 461)
			Me.metroStatusBar1.Name = "metroStatusBar1"
			Me.metroStatusBar1.Size = New System.Drawing.Size(779, 21)
			Me.metroStatusBar1.TabIndex = 2
			Me.metroStatusBar1.Text = "metroStatusBar1"
			' 
			' labelItem1
			' 
			Me.labelItem1.Name = "labelItem1"
			Me.labelItem1.Text = "READY"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(780, 483)
			Me.Controls.Add(Me.superTabControl1)
			Me.Controls.Add(Me.metroStatusBar1)
			Me.Controls.Add(Me.metroShell1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "DotNetBar Sample App"
			Me.metroShell1.ResumeLayout(False)
			Me.metroShell1.PerformLayout()
			Me.metroTabPanel1.ResumeLayout(False)
			Me.metroTabPanel3.ResumeLayout(False)
			Me.metroTabPanel2.ResumeLayout(False)
			CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.superTabControl1.ResumeLayout(False)
			Me.superTabControlPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private metroShell1 As DevComponents.DotNetBar.Metro.MetroShell
		Private metroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
		Private metroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
		Private metroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
		Private metroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
		Private metroTabItem2 As DevComponents.DotNetBar.Metro.MetroTabItem
		Private metroTabItem3 As DevComponents.DotNetBar.Metro.MetroTabItem
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private metroToolbar1 As DevComponents.DotNetBar.Metro.MetroToolbar
		Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem6 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem7 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem8 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem9 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem10 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem11 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem12 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem13 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem14 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem15 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem16 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem17 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem18 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem19 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem20 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem21 As DevComponents.DotNetBar.ButtonItem
		Private metroToolbar2 As DevComponents.DotNetBar.Metro.MetroToolbar
		Private buttonItem22 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem23 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem24 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem25 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem26 As DevComponents.DotNetBar.ButtonItem
		Private metroToolbar3 As DevComponents.DotNetBar.Metro.MetroToolbar
		Private buttonItem27 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem28 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem29 As DevComponents.DotNetBar.ButtonItem
		Private switchButtonItem1 As DevComponents.DotNetBar.SwitchButtonItem
		Private superTabControl1 As DevComponents.DotNetBar.SuperTabControl
		Private superTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem4 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem3 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem1 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem2 As DevComponents.DotNetBar.SuperTabItem
		Private superTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
		Private superTabItem5 As DevComponents.DotNetBar.SuperTabItem
		Private WithEvents richTextBoxEx1 As DevComponents.DotNetBar.Controls.RichTextBoxEx
		Private metroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
		Private labelItem1 As DevComponents.DotNetBar.LabelItem

	End Class
End Namespace

