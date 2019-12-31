<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPopulationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database3DataSet = New WindowsApp6.Database3DataSet()
        Me.Table1TableAdapter = New WindowsApp6.Database3DataSetTableAdapters.Table1TableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchToolStrip.SuspendLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(610, 46)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NUMBER OF WATER TREATMENT PLANTS AND POPULATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RECEIVING FLUORIDATED WATER SUPP" &
    "LIES, MALAYSIA (1996 - 2017)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Percentage of Estimated Population Receiving Fluoridated Water", True))
        Me.TextBox7.Location = New System.Drawing.Point(434, 256)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 45
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Number of Estimated Population Receiving Fluoridated Water", True))
        Me.TextBox6.Location = New System.Drawing.Point(434, 228)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 44
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Total Population", True))
        Me.TextBox5.Location = New System.Drawing.Point(434, 201)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 43
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Percentage of  Water Treatment Plants With Fluoride Feeders", True))
        Me.TextBox4.Location = New System.Drawing.Point(434, 168)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Number of  Water Treatment Plants With Fluoride Feeders", True))
        Me.TextBox3.Location = New System.Drawing.Point(434, 140)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Total Number of Water Treatment Plants", True))
        Me.TextBox2.Location = New System.Drawing.Point(434, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 40
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Year", True))
        Me.TextBox1.Location = New System.Drawing.Point(434, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(337, 26)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Percentage of Estimated Population Receiving Fluoridated Water (%) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[Note : Rou" &
    "nd Off]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(302, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Number of Estimated Population Receiving Fluoridated Water :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Total Population :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(324, 26)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Percentage of  Water Treatment Plants With Fluoride Feeders  (%) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[Note : Round" &
    " Off]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(286, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Number of  Water Treatment Plants With Fluoride Feeders :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Total Number of Water Treatment Plants :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Year :"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(562, 144)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(129, 66)
        Me.Button8.TabIndex = 46
        Me.Button8.Text = "Load Chart"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(394, 340)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = "Search"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(457, 299)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(150, 340)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(272, 340)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(336, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YearDataGridViewTextBoxColumn, Me.TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn, Me.NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn, Me.PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn, Me.TotalPopulationDataGridViewTextBoxColumn, Me.NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn, Me.PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 398)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 150)
        Me.DataGridView1.TabIndex = 54
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.SearchToolStrip.TabIndex = 55
        Me.SearchToolStrip.Text = "SearchToolStrip"
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.SearchToolStripButton.Text = "Search"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn
        '
        Me.TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn.DataPropertyName = "Total Number of Water Treatment Plants"
        Me.TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn.HeaderText = "Total Number of Water Treatment Plants"
        Me.TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn.Name = "TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn"
        '
        'NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn
        '
        Me.NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn.DataPropertyName = "Number of  Water Treatment Plants With Fluoride Feeders"
        Me.NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn.HeaderText = "Number of  Water Treatment Plants With Fluoride Feeders"
        Me.NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn.Name = "NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn"
        '
        'PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn
        '
        Me.PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn.DataPropertyName = "Percentage of  Water Treatment Plants With Fluoride Feeders"
        Me.PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn.HeaderText = "Percentage of  Water Treatment Plants With Fluoride Feeders"
        Me.PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn.Name = "PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn"
        '
        'TotalPopulationDataGridViewTextBoxColumn
        '
        Me.TotalPopulationDataGridViewTextBoxColumn.DataPropertyName = "Total Population"
        Me.TotalPopulationDataGridViewTextBoxColumn.HeaderText = "Total Population"
        Me.TotalPopulationDataGridViewTextBoxColumn.Name = "TotalPopulationDataGridViewTextBoxColumn"
        '
        'NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn
        '
        Me.NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn.DataPropertyName = "Number of Estimated Population Receiving Fluoridated Water"
        Me.NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn.HeaderText = "Number of Estimated Population Receiving Fluoridated Water"
        Me.NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn.Name = "NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn"
        '
        'PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn
        '
        Me.PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn.DataPropertyName = "Percentage of Estimated Population Receiving Fluoridated Water"
        Me.PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn.HeaderText = "Percentage of Estimated Population Receiving Fluoridated Water"
        Me.PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn.Name = "PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn" &
    ""
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database3DataSet
        '
        'Database3DataSet
        '
        Me.Database3DataSet.DataSetName = "Database3DataSet"
        Me.Database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 572)
        Me.Controls.Add(Me.SearchToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database3DataSet As Database3DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Database3DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalNumberOfWaterTreatmentPlantsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PercentageOfWaterTreatmentPlantsWithFluorideFeedersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPopulationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PercentageOfEstimatedPopulationReceivingFluoridatedWaterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SearchToolStrip As ToolStrip
    Friend WithEvents SearchToolStripButton As ToolStripButton
End Class
