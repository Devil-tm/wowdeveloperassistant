﻿namespace WoWDeveloperAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_CreatureScriptsCreator = new System.Windows.Forms.TabPage();
            this.checkBox_CreatureScriptsCreator_CreateDataFile = new System.Windows.Forms.CheckBox();
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells = new System.Windows.Forms.CheckBox();
            this.dataGridView_CreatureScriptsCreator_Spells = new System.Windows.Forms.DataGridView();
            this.SpellId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCastStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCastStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCastRepeatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCastRepeatTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceSpell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_CreatureScriptsCreator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.createSmartAISqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLegionCombatAISqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCoreScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_CreatureScriptCreator_CreatureGuids = new System.Windows.Forms.ListBox();
            this.toolStrip_CreatureScriptsCreator = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_CSC_ImportSniff = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CreatureScriptsCreator_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator_CSC = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage_WaypointsCreator = new System.Windows.Forms.TabPage();
            this.checkBox_WaypointsCreator_CreateDataFile = new System.Windows.Forms.CheckBox();
            this.grid_WaypointsCreator_Waypoints = new System.Windows.Forms.DataGridView();
            this.gridColumn_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_PosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_PosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_PosZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_Orientation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_WCTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_WCDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_HasScript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaypointSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_WaypointsCreator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNearestPointsToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDuplicatePointsToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.createReturnPathToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_WC = new System.Windows.Forms.ToolStripSeparator();
            this.createSQLToolStripMenuItem_WC = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_WaypointsCreator_CreatureGuids = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_WaypointsCreator_Guids = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeGuidsBeforeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRandomMovementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInhabitTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart_WaypointsCreator_Path = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip_WaypointsCreator = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_WaypointsCreator_Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_WaypointsCreator_Entry = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_WaypointsCreator_Entry = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_WaypointsCreator_Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_WaypointsCreator_LoadSniff = new System.Windows.Forms.ToolStripButton();
            this.tabPage_SqlOutput = new System.Windows.Forms.TabPage();
            this.textBox_SqlOutput = new System.Windows.Forms.TextBox();
            this.tabPage_DatabaseAdvisor = new System.Windows.Forms.TabPage();
            this.textBox_DatabaseAdvisor_FindDoublePaths = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_FindDoublePaths = new System.Windows.Forms.Label();
            this.textBox_DatabaseAdvisor_PlayerCastedSpells = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_PlayerCasterSpells = new System.Windows.Forms.Label();
            this.textBox_DatabaseAdvisor_Output = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_DatabaseAdvisor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createReturnPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recalculatePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAddonsFromSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_DatabaseAdvisor_GossipMenuText = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_GossipMenuText = new System.Windows.Forms.Label();
            this.textBox_DatabaseAdvisor_SpellDestinations = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_SpellDestinations = new System.Windows.Forms.Label();
            this.textBox_DatabaseAdvisor_AreatriggerSplines = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_AreatriggerSplines = new System.Windows.Forms.Label();
            this.textBox_DatabaseAdvisor_QuestFlags = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_QuestFlags = new System.Windows.Forms.Label();
            this.textBox_DatabaseAdvisor_CreatureFlags = new System.Windows.Forms.TextBox();
            this.label_DatabaseAdvisor_CreatureFlags = new System.Windows.Forms.Label();
            this.tabPage_DoubleSpawnsRemover = new System.Windows.Forms.TabPage();
            this.label_DoubleSpawnsRemover_GameobjectsRemoved = new System.Windows.Forms.Label();
            this.checkBox_DoubleSpawnsRemover_Gameobjects = new System.Windows.Forms.CheckBox();
            this.checkBox_DoubleSpawnsRemover_Creatures = new System.Windows.Forms.CheckBox();
            this.label_DoubleSpawnsRemover_CreaturesRemoved = new System.Windows.Forms.Label();
            this.button_DoubleSpawnsRemover_ImportFile = new System.Windows.Forms.Button();
            this.tabPage_CoreScriptTemplates = new System.Windows.Forms.TabPage();
            this.treeView_CoreScriptTemplates_HookBodies = new System.Windows.Forms.TreeView();
            this.label_CoreScriptTemplates_ScriptType = new System.Windows.Forms.Label();
            this.comboBox_CoreScriptTemplates_ScriptType = new System.Windows.Forms.ComboBox();
            this.label_CoreScriptTemplates_ObjectId = new System.Windows.Forms.Label();
            this.textBox_CoreScriptTemplates_ObjectId = new System.Windows.Forms.TextBox();
            this.listBox_CoreScriptTemplates_Hooks = new System.Windows.Forms.ListBox();
            this.tabPage_Achievements = new System.Windows.Forms.TabPage();
            this.label_Achievements_ModifierTreeChildNodes = new System.Windows.Forms.Label();
            this.treeView_Achievements_ModifierTreeChildNodes = new System.Windows.Forms.TreeView();
            this.label_Achievements_ModifierTrees = new System.Windows.Forms.Label();
            this.treeView_Achievements_ModifierTrees = new System.Windows.Forms.TreeView();
            this.label_Achievements_Criterias = new System.Windows.Forms.Label();
            this.treeView_Achievements_Criterias = new System.Windows.Forms.TreeView();
            this.label_Achievements_CriteriaTreeAmount = new System.Windows.Forms.Label();
            this.label_Achievements_CriteriaTreeChildNodes = new System.Windows.Forms.Label();
            this.label_Achievement_CriteriaTreeOperator = new System.Windows.Forms.Label();
            this.label_Achievements_CriteriaTreeName = new System.Windows.Forms.Label();
            this.label_Achievements_CriteriaTreeId = new System.Windows.Forms.Label();
            this.label_Achievements_AchievementFlags = new System.Windows.Forms.Label();
            this.label_Achievements_AchievementFaction = new System.Windows.Forms.Label();
            this.treeView_Achievements_ChildNodes = new System.Windows.Forms.TreeView();
            this.label_Achievements_AchievementName = new System.Windows.Forms.Label();
            this.textBox_Achievements_AchievementId = new System.Windows.Forms.TextBox();
            this.label_Achievements_AchievementId = new System.Windows.Forms.Label();
            this.tabPage_ConditionsCreator = new System.Windows.Forms.TabPage();
            this.button_ConditionsCreator_ClearConditions = new System.Windows.Forms.Button();
            this.button_ConditionsCreator_AddCondition = new System.Windows.Forms.Button();
            this.textBox_ConditionsCreator_Output = new System.Windows.Forms.TextBox();
            this.label_ConditionsCreator_ScriptName = new System.Windows.Forms.Label();
            this.label_ConditionsCreator_NegativeCondition = new System.Windows.Forms.Label();
            this.label_ConditionsCreator_ConditionValue3 = new System.Windows.Forms.Label();
            this.label_ConditionsCreator_ConditionValue2 = new System.Windows.Forms.Label();
            this.label_ConditionsCreator_ConditionValue1 = new System.Windows.Forms.Label();
            this.textBox_ConditionsCreator_ScriptName = new System.Windows.Forms.TextBox();
            this.textBox_ConditionsCreator_NegativeCondition = new System.Windows.Forms.TextBox();
            this.textBox_ConditionsCreator_ConditionValue3 = new System.Windows.Forms.TextBox();
            this.textBox_ConditionsCreator_ConditionValue2 = new System.Windows.Forms.TextBox();
            this.textBox_ConditionsCreator_ConditionValue1 = new System.Windows.Forms.TextBox();
            this.textBox_ConditionsCreator_ConditionTarget = new System.Windows.Forms.TextBox();
            this.label_ConditionsCreator_ConditionTarget = new System.Windows.Forms.Label();
            this.label_ConditionsCreator_ConditionType = new System.Windows.Forms.Label();
            this.comboBox_ConditionsCreator_ConditionType = new System.Windows.Forms.ComboBox();
            this.textBox_ConditionsCreator_ElseGroup = new System.Windows.Forms.TextBox();
            this.label_ConditionsCreator_ElseGroup = new System.Windows.Forms.Label();
            this.textBox_ConditionsCreator_SourceId = new System.Windows.Forms.TextBox();
            this.label_ConditionsCreator_SourceId = new System.Windows.Forms.Label();
            this.textBox_ConditionsCreator_SourceEntry = new System.Windows.Forms.TextBox();
            this.label_ConditionsCreator_SourceEntry = new System.Windows.Forms.Label();
            this.textBox_ConditionsCreator_SourceGroup = new System.Windows.Forms.TextBox();
            this.label_ConditionsCreator_ConditionSourceGroup = new System.Windows.Forms.Label();
            this.comboBox_ConditionsCreator_ConditionSourceType = new System.Windows.Forms.ComboBox();
            this.label_ConditionsCreator_ConditionSourceType = new System.Windows.Forms.Label();
            this.tabPage_ModifierTrees = new System.Windows.Forms.TabPage();
            this.label_ModifierTrees_TertiaryAsset = new System.Windows.Forms.Label();
            this.label_ModifierTrees_SecondaryAsset = new System.Windows.Forms.Label();
            this.label_ModifierTrees_Asset = new System.Windows.Forms.Label();
            this.label_ModifierTrees_Amount = new System.Windows.Forms.Label();
            this.label_ModifierTrees_Operator = new System.Windows.Forms.Label();
            this.label_ModifierTrees_Type = new System.Windows.Forms.Label();
            this.textBox_ModifierTrees_ModifierTreeId = new System.Windows.Forms.TextBox();
            this.label_ModifierTrees_ModifierTreeId = new System.Windows.Forms.Label();
            this.label_ModifierTrees_ModifierTrees = new System.Windows.Forms.Label();
            this.treeView_ModifierTrees_ModifierTrees = new System.Windows.Forms.TreeView();
            this.statusStrip_LoadedFile = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_FileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_CurrentAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Core_script_creatore_preview = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPage_CreatureScriptsCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CreatureScriptsCreator_Spells)).BeginInit();
            this.contextMenuStrip_CreatureScriptsCreator.SuspendLayout();
            this.toolStrip_CreatureScriptsCreator.SuspendLayout();
            this.tabPage_WaypointsCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WaypointsCreator_Waypoints)).BeginInit();
            this.contextMenuStrip_WaypointsCreator.SuspendLayout();
            this.contextMenuStrip_WaypointsCreator_Guids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_WaypointsCreator_Path)).BeginInit();
            this.toolStrip_WaypointsCreator.SuspendLayout();
            this.tabPage_SqlOutput.SuspendLayout();
            this.tabPage_DatabaseAdvisor.SuspendLayout();
            this.contextMenuStrip_DatabaseAdvisor.SuspendLayout();
            this.tabPage_DoubleSpawnsRemover.SuspendLayout();
            this.tabPage_CoreScriptTemplates.SuspendLayout();
            this.tabPage_Achievements.SuspendLayout();
            this.tabPage_ConditionsCreator.SuspendLayout();
            this.tabPage_ModifierTrees.SuspendLayout();
            this.statusStrip_LoadedFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_CreatureScriptsCreator);
            this.tabControl.Controls.Add(this.tabPage_WaypointsCreator);
            this.tabControl.Controls.Add(this.tabPage_SqlOutput);
            this.tabControl.Controls.Add(this.tabPage_DatabaseAdvisor);
            this.tabControl.Controls.Add(this.tabPage_DoubleSpawnsRemover);
            this.tabControl.Controls.Add(this.tabPage_CoreScriptTemplates);
            this.tabControl.Controls.Add(this.tabPage_Achievements);
            this.tabControl.Controls.Add(this.tabPage_ConditionsCreator);
            this.tabControl.Controls.Add(this.tabPage_ModifierTrees);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1820, 790);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_CreatureScriptsCreator
            // 
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.checkBox_CreatureScriptsCreator_CreateDataFile);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.checkBox_CreatureScriptsCreator_OnlyCombatSpells);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.dataGridView_CreatureScriptsCreator_Spells);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.listBox_CreatureScriptCreator_CreatureGuids);
            this.tabPage_CreatureScriptsCreator.Controls.Add(this.toolStrip_CreatureScriptsCreator);
            this.tabPage_CreatureScriptsCreator.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CreatureScriptsCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_CreatureScriptsCreator.Name = "tabPage_CreatureScriptsCreator";
            this.tabPage_CreatureScriptsCreator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_CreatureScriptsCreator.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_CreatureScriptsCreator.TabIndex = 0;
            this.tabPage_CreatureScriptsCreator.Text = "Creature Scripts Creator";
            this.tabPage_CreatureScriptsCreator.UseVisualStyleBackColor = true;
            // 
            // checkBox_CreatureScriptsCreator_CreateDataFile
            // 
            this.checkBox_CreatureScriptsCreator_CreateDataFile.AutoSize = true;
            this.checkBox_CreatureScriptsCreator_CreateDataFile.BackColor = System.Drawing.Color.LightGray;
            this.checkBox_CreatureScriptsCreator_CreateDataFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_CreatureScriptsCreator_CreateDataFile.Location = new System.Drawing.Point(1098, 6);
            this.checkBox_CreatureScriptsCreator_CreateDataFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_CreatureScriptsCreator_CreateDataFile.Name = "checkBox_CreatureScriptsCreator_CreateDataFile";
            this.checkBox_CreatureScriptsCreator_CreateDataFile.Size = new System.Drawing.Size(137, 24);
            this.checkBox_CreatureScriptsCreator_CreateDataFile.TabIndex = 5;
            this.checkBox_CreatureScriptsCreator_CreateDataFile.Text = "Create Data File";
            this.checkBox_CreatureScriptsCreator_CreateDataFile.UseVisualStyleBackColor = false;
            // 
            // checkBox_CreatureScriptsCreator_OnlyCombatSpells
            // 
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.AutoSize = true;
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.BackColor = System.Drawing.Color.LightGray;
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Checked = true;
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Location = new System.Drawing.Point(1246, 6);
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Name = "checkBox_CreatureScriptsCreator_OnlyCombatSpells";
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Size = new System.Drawing.Size(201, 24);
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.TabIndex = 4;
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.Text = "Show Only Combat Spells";
            this.checkBox_CreatureScriptsCreator_OnlyCombatSpells.UseVisualStyleBackColor = false;
            // 
            // dataGridView_CreatureScriptsCreator_Spells
            // 
            this.dataGridView_CreatureScriptsCreator_Spells.AllowUserToAddRows = false;
            this.dataGridView_CreatureScriptsCreator_Spells.AllowUserToDeleteRows = false;
            this.dataGridView_CreatureScriptsCreator_Spells.AllowUserToOrderColumns = true;
            this.dataGridView_CreatureScriptsCreator_Spells.AllowUserToResizeColumns = false;
            this.dataGridView_CreatureScriptsCreator_Spells.AllowUserToResizeRows = false;
            this.dataGridView_CreatureScriptsCreator_Spells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CreatureScriptsCreator_Spells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CreatureScriptsCreator_Spells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpellId,
            this.SpellName,
            this.CastTime,
            this.MinCastStartTime,
            this.MaxCastStartTime,
            this.MinCastRepeatTime,
            this.MaxCastRepeatTime,
            this.CastsCount,
            this.SourceSpell});
            this.dataGridView_CreatureScriptsCreator_Spells.ContextMenuStrip = this.contextMenuStrip_CreatureScriptsCreator;
            this.dataGridView_CreatureScriptsCreator_Spells.Enabled = false;
            this.dataGridView_CreatureScriptsCreator_Spells.Location = new System.Drawing.Point(676, 39);
            this.dataGridView_CreatureScriptsCreator_Spells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_CreatureScriptsCreator_Spells.Name = "dataGridView_CreatureScriptsCreator_Spells";
            this.dataGridView_CreatureScriptsCreator_Spells.RowHeadersWidth = 62;
            this.dataGridView_CreatureScriptsCreator_Spells.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_CreatureScriptsCreator_Spells.RowTemplate.Height = 28;
            this.dataGridView_CreatureScriptsCreator_Spells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CreatureScriptsCreator_Spells.Size = new System.Drawing.Size(1128, 709);
            this.dataGridView_CreatureScriptsCreator_Spells.TabIndex = 3;
            // 
            // SpellId
            // 
            this.SpellId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SpellId.DefaultCellStyle = dataGridViewCellStyle29;
            this.SpellId.HeaderText = "SpellId";
            this.SpellId.MaxInputLength = 10;
            this.SpellId.MinimumWidth = 8;
            this.SpellId.Name = "SpellId";
            this.SpellId.ReadOnly = true;
            this.SpellId.Width = 79;
            // 
            // SpellName
            // 
            this.SpellName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SpellName.DefaultCellStyle = dataGridViewCellStyle30;
            this.SpellName.HeaderText = "SpellName";
            this.SpellName.MaxInputLength = 50;
            this.SpellName.MinimumWidth = 8;
            this.SpellName.Name = "SpellName";
            this.SpellName.ReadOnly = true;
            this.SpellName.Width = 105;
            // 
            // CastTime
            // 
            this.CastTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CastTime.DefaultCellStyle = dataGridViewCellStyle39;
            this.CastTime.HeaderText = "CastTime";
            this.CastTime.MaxInputLength = 10;
            this.CastTime.MinimumWidth = 8;
            this.CastTime.Name = "CastTime";
            this.CastTime.ReadOnly = true;
            this.CastTime.Width = 96;
            // 
            // MinCastStartTime
            // 
            this.MinCastStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinCastStartTime.DefaultCellStyle = dataGridViewCellStyle40;
            this.MinCastStartTime.HeaderText = "MinCastStartTime";
            this.MinCastStartTime.MaxInputLength = 10;
            this.MinCastStartTime.MinimumWidth = 8;
            this.MinCastStartTime.Name = "MinCastStartTime";
            this.MinCastStartTime.ReadOnly = true;
            this.MinCastStartTime.Width = 148;
            // 
            // MaxCastStartTime
            // 
            this.MaxCastStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxCastStartTime.DefaultCellStyle = dataGridViewCellStyle57;
            this.MaxCastStartTime.HeaderText = "MaxCastStartTime";
            this.MaxCastStartTime.MaxInputLength = 10;
            this.MaxCastStartTime.MinimumWidth = 8;
            this.MaxCastStartTime.Name = "MaxCastStartTime";
            this.MaxCastStartTime.ReadOnly = true;
            this.MaxCastStartTime.Width = 151;
            // 
            // MinCastRepeatTime
            // 
            this.MinCastRepeatTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinCastRepeatTime.DefaultCellStyle = dataGridViewCellStyle58;
            this.MinCastRepeatTime.HeaderText = "MinCastRepeatTime";
            this.MinCastRepeatTime.MaxInputLength = 10;
            this.MinCastRepeatTime.MinimumWidth = 8;
            this.MinCastRepeatTime.Name = "MinCastRepeatTime";
            this.MinCastRepeatTime.ReadOnly = true;
            this.MinCastRepeatTime.Width = 164;
            // 
            // MaxCastRepeatTime
            // 
            this.MaxCastRepeatTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxCastRepeatTime.DefaultCellStyle = dataGridViewCellStyle59;
            this.MaxCastRepeatTime.HeaderText = "MaxCastRepeatTime";
            this.MaxCastRepeatTime.MaxInputLength = 10;
            this.MaxCastRepeatTime.MinimumWidth = 8;
            this.MaxCastRepeatTime.Name = "MaxCastRepeatTime";
            this.MaxCastRepeatTime.ReadOnly = true;
            this.MaxCastRepeatTime.Width = 167;
            // 
            // CastsCount
            // 
            this.CastsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CastsCount.DefaultCellStyle = dataGridViewCellStyle60;
            this.CastsCount.HeaderText = "CastsCount";
            this.CastsCount.MaxInputLength = 4;
            this.CastsCount.MinimumWidth = 8;
            this.CastsCount.Name = "CastsCount";
            this.CastsCount.ReadOnly = true;
            this.CastsCount.Width = 109;
            // 
            // SourceSpell
            // 
            this.SourceSpell.HeaderText = "SourceSpell";
            this.SourceSpell.MinimumWidth = 8;
            this.SourceSpell.Name = "SourceSpell";
            this.SourceSpell.Visible = false;
            this.SourceSpell.Width = 150;
            // 
            // contextMenuStrip_CreatureScriptsCreator
            // 
            this.contextMenuStrip_CreatureScriptsCreator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_CreatureScriptsCreator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.toolStripSeparator,
            this.createSmartAISqlToolStripMenuItem,
            this.createLegionCombatAISqlToolStripMenuItem,
            this.createCoreScriptToolStripMenuItem});
            this.contextMenuStrip_CreatureScriptsCreator.Name = "contextMenuStrip1";
            this.contextMenuStrip_CreatureScriptsCreator.Size = new System.Drawing.Size(268, 106);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(264, 6);
            // 
            // createSmartAISqlToolStripMenuItem
            // 
            this.createSmartAISqlToolStripMenuItem.Name = "createSmartAISqlToolStripMenuItem";
            this.createSmartAISqlToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.createSmartAISqlToolStripMenuItem.Text = "Create SmartAI SQL";
            this.createSmartAISqlToolStripMenuItem.Click += new System.EventHandler(this.createSQLToolStripMenuItem_Click);
            // 
            // createLegionCombatAISqlToolStripMenuItem
            // 
            this.createLegionCombatAISqlToolStripMenuItem.Name = "createLegionCombatAISqlToolStripMenuItem";
            this.createLegionCombatAISqlToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.createLegionCombatAISqlToolStripMenuItem.Text = "Create LegionCombatAI SQL";
            this.createLegionCombatAISqlToolStripMenuItem.Click += new System.EventHandler(this.createLegionCombatAISqlToolStripMenuItem_Click);
            // 
            // createCoreScriptToolStripMenuItem
            // 
            this.createCoreScriptToolStripMenuItem.Name = "createCoreScriptToolStripMenuItem";
            this.createCoreScriptToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.createCoreScriptToolStripMenuItem.Text = "Create core script";
            this.createCoreScriptToolStripMenuItem.Click += new System.EventHandler(this.createCoreScriptToolStripMenuItem_Click);
            // 
            // listBox_CreatureScriptCreator_CreatureGuids
            // 
            this.listBox_CreatureScriptCreator_CreatureGuids.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_CreatureScriptCreator_CreatureGuids.Enabled = false;
            this.listBox_CreatureScriptCreator_CreatureGuids.FormattingEnabled = true;
            this.listBox_CreatureScriptCreator_CreatureGuids.ItemHeight = 16;
            this.listBox_CreatureScriptCreator_CreatureGuids.Location = new System.Drawing.Point(7, 39);
            this.listBox_CreatureScriptCreator_CreatureGuids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_CreatureScriptCreator_CreatureGuids.Name = "listBox_CreatureScriptCreator_CreatureGuids";
            this.listBox_CreatureScriptCreator_CreatureGuids.Size = new System.Drawing.Size(646, 708);
            this.listBox_CreatureScriptCreator_CreatureGuids.TabIndex = 2;
            this.listBox_CreatureScriptCreator_CreatureGuids.SelectedIndexChanged += new System.EventHandler(this.listBox_CreatureGuids_SelectedIndexChanged);
            // 
            // toolStrip_CreatureScriptsCreator
            // 
            this.toolStrip_CreatureScriptsCreator.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip_CreatureScriptsCreator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_CreatureScriptsCreator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_CSC_ImportSniff,
            this.toolStripButton_CreatureScriptsCreator_Search,
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry,
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry,
            this.toolStripSeparator_CSC});
            this.toolStrip_CreatureScriptsCreator.Location = new System.Drawing.Point(3, 2);
            this.toolStrip_CreatureScriptsCreator.Name = "toolStrip_CreatureScriptsCreator";
            this.toolStrip_CreatureScriptsCreator.Size = new System.Drawing.Size(1806, 27);
            this.toolStrip_CreatureScriptsCreator.TabIndex = 1;
            this.toolStrip_CreatureScriptsCreator.Text = "toolStrip_CreatureScriptsCreator";
            // 
            // toolStripButton_CSC_ImportSniff
            // 
            this.toolStripButton_CSC_ImportSniff.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CSC_ImportSniff.Image")));
            this.toolStripButton_CSC_ImportSniff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CSC_ImportSniff.Name = "toolStripButton_CSC_ImportSniff";
            this.toolStripButton_CSC_ImportSniff.Size = new System.Drawing.Size(112, 24);
            this.toolStripButton_CSC_ImportSniff.Text = "Import Sniff";
            this.toolStripButton_CSC_ImportSniff.Click += new System.EventHandler(this.toolStripButton_ImportSniff_Click);
            // 
            // toolStripButton_CreatureScriptsCreator_Search
            // 
            this.toolStripButton_CreatureScriptsCreator_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_CreatureScriptsCreator_Search.Enabled = false;
            this.toolStripButton_CreatureScriptsCreator_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CreatureScriptsCreator_Search.Image")));
            this.toolStripButton_CreatureScriptsCreator_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CreatureScriptsCreator_Search.Name = "toolStripButton_CreatureScriptsCreator_Search";
            this.toolStripButton_CreatureScriptsCreator_Search.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton_CreatureScriptsCreator_Search.Text = "Search";
            this.toolStripButton_CreatureScriptsCreator_Search.Click += new System.EventHandler(this.toolStripButton_Search_Click);
            // 
            // toolStripTextBox_CreatureScriptsCreator_CreatureEntry
            // 
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.Enabled = false;
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.MaxLength = 40;
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.Name = "toolStripTextBox_CreatureScriptsCreator_CreatureEntry";
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.Size = new System.Drawing.Size(89, 27);
            this.toolStripTextBox_CreatureScriptsCreator_CreatureEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_CSC_CreatureEntrySearch_Enter);
            // 
            // toolStripLabel_CreatureScriptsCreator_CreatureEntry
            // 
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry.Name = "toolStripLabel_CreatureScriptsCreator_CreatureEntry";
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry.Size = new System.Drawing.Size(152, 24);
            this.toolStripLabel_CreatureScriptsCreator_CreatureEntry.Text = "Creature EntryOrGuid:";
            // 
            // toolStripSeparator_CSC
            // 
            this.toolStripSeparator_CSC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator_CSC.Name = "toolStripSeparator_CSC";
            this.toolStripSeparator_CSC.Size = new System.Drawing.Size(6, 27);
            // 
            // tabPage_WaypointsCreator
            // 
            this.tabPage_WaypointsCreator.Controls.Add(this.checkBox_WaypointsCreator_CreateDataFile);
            this.tabPage_WaypointsCreator.Controls.Add(this.grid_WaypointsCreator_Waypoints);
            this.tabPage_WaypointsCreator.Controls.Add(this.listBox_WaypointsCreator_CreatureGuids);
            this.tabPage_WaypointsCreator.Controls.Add(this.chart_WaypointsCreator_Path);
            this.tabPage_WaypointsCreator.Controls.Add(this.toolStrip_WaypointsCreator);
            this.tabPage_WaypointsCreator.Location = new System.Drawing.Point(4, 25);
            this.tabPage_WaypointsCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_WaypointsCreator.Name = "tabPage_WaypointsCreator";
            this.tabPage_WaypointsCreator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_WaypointsCreator.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_WaypointsCreator.TabIndex = 4;
            this.tabPage_WaypointsCreator.Text = "Waypoints Creator";
            this.tabPage_WaypointsCreator.UseVisualStyleBackColor = true;
            // 
            // checkBox_WaypointsCreator_CreateDataFile
            // 
            this.checkBox_WaypointsCreator_CreateDataFile.AutoSize = true;
            this.checkBox_WaypointsCreator_CreateDataFile.BackColor = System.Drawing.Color.LightGray;
            this.checkBox_WaypointsCreator_CreateDataFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_WaypointsCreator_CreateDataFile.Location = new System.Drawing.Point(1217, 6);
            this.checkBox_WaypointsCreator_CreateDataFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_WaypointsCreator_CreateDataFile.Name = "checkBox_WaypointsCreator_CreateDataFile";
            this.checkBox_WaypointsCreator_CreateDataFile.Size = new System.Drawing.Size(137, 24);
            this.checkBox_WaypointsCreator_CreateDataFile.TabIndex = 29;
            this.checkBox_WaypointsCreator_CreateDataFile.Text = "Create Data File";
            this.checkBox_WaypointsCreator_CreateDataFile.UseVisualStyleBackColor = false;
            // 
            // grid_WaypointsCreator_Waypoints
            // 
            this.grid_WaypointsCreator_Waypoints.AllowUserToAddRows = false;
            this.grid_WaypointsCreator_Waypoints.AllowUserToDeleteRows = false;
            this.grid_WaypointsCreator_Waypoints.AllowUserToResizeColumns = false;
            this.grid_WaypointsCreator_Waypoints.AllowUserToResizeRows = false;
            dataGridViewCellStyle61.NullValue = null;
            this.grid_WaypointsCreator_Waypoints.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.grid_WaypointsCreator_Waypoints.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle62.NullValue = null;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_WaypointsCreator_Waypoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.grid_WaypointsCreator_Waypoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_WaypointsCreator_Waypoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumn_Id,
            this.gridColumn_PosX,
            this.gridColumn_PosY,
            this.gridColumn_PosZ,
            this.gridColumn_Orientation,
            this.gridColumn_WCTime,
            this.gridColumn_WCDelay,
            this.gridColumn_HasScript,
            this.WaypointSource});
            this.grid_WaypointsCreator_Waypoints.ContextMenuStrip = this.contextMenuStrip_WaypointsCreator;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle71.NullValue = null;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_WaypointsCreator_Waypoints.DefaultCellStyle = dataGridViewCellStyle71;
            this.grid_WaypointsCreator_Waypoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_WaypointsCreator_Waypoints.Enabled = false;
            this.grid_WaypointsCreator_Waypoints.Location = new System.Drawing.Point(1132, 39);
            this.grid_WaypointsCreator_Waypoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_WaypointsCreator_Waypoints.Name = "grid_WaypointsCreator_Waypoints";
            this.grid_WaypointsCreator_Waypoints.RowHeadersWidth = 62;
            this.grid_WaypointsCreator_Waypoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_WaypointsCreator_Waypoints.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.grid_WaypointsCreator_Waypoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_WaypointsCreator_Waypoints.Size = new System.Drawing.Size(684, 709);
            this.grid_WaypointsCreator_Waypoints.TabIndex = 28;
            this.grid_WaypointsCreator_Waypoints.TabStop = false;
            // 
            // gridColumn_Id
            // 
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_Id.DefaultCellStyle = dataGridViewCellStyle63;
            this.gridColumn_Id.HeaderText = "Id";
            this.gridColumn_Id.MinimumWidth = 8;
            this.gridColumn_Id.Name = "gridColumn_Id";
            this.gridColumn_Id.ReadOnly = true;
            this.gridColumn_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gridColumn_Id.Width = 35;
            // 
            // gridColumn_PosX
            // 
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle64.NullValue = null;
            this.gridColumn_PosX.DefaultCellStyle = dataGridViewCellStyle64;
            this.gridColumn_PosX.HeaderText = "PosX";
            this.gridColumn_PosX.MinimumWidth = 8;
            this.gridColumn_PosX.Name = "gridColumn_PosX";
            this.gridColumn_PosX.ReadOnly = true;
            this.gridColumn_PosX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosX.Width = 60;
            // 
            // gridColumn_PosY
            // 
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle65.NullValue = null;
            this.gridColumn_PosY.DefaultCellStyle = dataGridViewCellStyle65;
            this.gridColumn_PosY.HeaderText = "PosY";
            this.gridColumn_PosY.MinimumWidth = 8;
            this.gridColumn_PosY.Name = "gridColumn_PosY";
            this.gridColumn_PosY.ReadOnly = true;
            this.gridColumn_PosY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosY.Width = 60;
            // 
            // gridColumn_PosZ
            // 
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_PosZ.DefaultCellStyle = dataGridViewCellStyle66;
            this.gridColumn_PosZ.HeaderText = "PosZ";
            this.gridColumn_PosZ.MinimumWidth = 8;
            this.gridColumn_PosZ.Name = "gridColumn_PosZ";
            this.gridColumn_PosZ.ReadOnly = true;
            this.gridColumn_PosZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_PosZ.Width = 60;
            // 
            // gridColumn_Orientation
            // 
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_Orientation.DefaultCellStyle = dataGridViewCellStyle67;
            this.gridColumn_Orientation.HeaderText = "Orientation";
            this.gridColumn_Orientation.MinimumWidth = 8;
            this.gridColumn_Orientation.Name = "gridColumn_Orientation";
            this.gridColumn_Orientation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumn_Orientation.Width = 65;
            // 
            // gridColumn_WCTime
            // 
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_WCTime.DefaultCellStyle = dataGridViewCellStyle68;
            this.gridColumn_WCTime.HeaderText = "Time";
            this.gridColumn_WCTime.MinimumWidth = 8;
            this.gridColumn_WCTime.Name = "gridColumn_WCTime";
            this.gridColumn_WCTime.ReadOnly = true;
            this.gridColumn_WCTime.Width = 60;
            // 
            // gridColumn_WCDelay
            // 
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_WCDelay.DefaultCellStyle = dataGridViewCellStyle69;
            this.gridColumn_WCDelay.HeaderText = "Delay";
            this.gridColumn_WCDelay.MinimumWidth = 8;
            this.gridColumn_WCDelay.Name = "gridColumn_WCDelay";
            this.gridColumn_WCDelay.Width = 50;
            // 
            // gridColumn_HasScript
            // 
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridColumn_HasScript.DefaultCellStyle = dataGridViewCellStyle70;
            this.gridColumn_HasScript.HeaderText = "HasScript";
            this.gridColumn_HasScript.MinimumWidth = 8;
            this.gridColumn_HasScript.Name = "gridColumn_HasScript";
            this.gridColumn_HasScript.ReadOnly = true;
            this.gridColumn_HasScript.Width = 60;
            // 
            // WaypointSource
            // 
            this.WaypointSource.HeaderText = "WaypointSource";
            this.WaypointSource.MinimumWidth = 8;
            this.WaypointSource.Name = "WaypointSource";
            this.WaypointSource.Visible = false;
            this.WaypointSource.Width = 150;
            // 
            // contextMenuStrip_WaypointsCreator
            // 
            this.contextMenuStrip_WaypointsCreator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_WaypointsCreator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem_WC,
            this.removeNearestPointsToolStripMenuItem_WC,
            this.removeDuplicatePointsToolStripMenuItem_WC,
            this.createReturnPathToolStripMenuItem_WC,
            this.toolStripSeparator_WC,
            this.createSQLToolStripMenuItem_WC});
            this.contextMenuStrip_WaypointsCreator.Name = "contextMenuStrip_WC";
            this.contextMenuStrip_WaypointsCreator.Size = new System.Drawing.Size(244, 130);
            // 
            // cutToolStripMenuItem_WC
            // 
            this.cutToolStripMenuItem_WC.Name = "cutToolStripMenuItem_WC";
            this.cutToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.cutToolStripMenuItem_WC.Text = "Cut";
            this.cutToolStripMenuItem_WC.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // removeNearestPointsToolStripMenuItem_WC
            // 
            this.removeNearestPointsToolStripMenuItem_WC.Name = "removeNearestPointsToolStripMenuItem_WC";
            this.removeNearestPointsToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.removeNearestPointsToolStripMenuItem_WC.Text = "Remove nearest points";
            this.removeNearestPointsToolStripMenuItem_WC.Click += new System.EventHandler(this.removeExcessPointsToolStripMenuItem_Click);
            // 
            // removeDuplicatePointsToolStripMenuItem_WC
            // 
            this.removeDuplicatePointsToolStripMenuItem_WC.Name = "removeDuplicatePointsToolStripMenuItem_WC";
            this.removeDuplicatePointsToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.removeDuplicatePointsToolStripMenuItem_WC.Text = "Remove duplicate points";
            this.removeDuplicatePointsToolStripMenuItem_WC.Click += new System.EventHandler(this.removeDuplicatePointsToolStripMenuItem_WC_Click);
            // 
            // createReturnPathToolStripMenuItem_WC
            // 
            this.createReturnPathToolStripMenuItem_WC.Name = "createReturnPathToolStripMenuItem_WC";
            this.createReturnPathToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.createReturnPathToolStripMenuItem_WC.Text = "Create return path";
            this.createReturnPathToolStripMenuItem_WC.Click += new System.EventHandler(this.createReturnPathToolStripMenuItem_WC_Click);
            // 
            // toolStripSeparator_WC
            // 
            this.toolStripSeparator_WC.Name = "toolStripSeparator_WC";
            this.toolStripSeparator_WC.Size = new System.Drawing.Size(240, 6);
            // 
            // createSQLToolStripMenuItem_WC
            // 
            this.createSQLToolStripMenuItem_WC.Name = "createSQLToolStripMenuItem_WC";
            this.createSQLToolStripMenuItem_WC.Size = new System.Drawing.Size(243, 24);
            this.createSQLToolStripMenuItem_WC.Text = "Create SQL";
            this.createSQLToolStripMenuItem_WC.Click += new System.EventHandler(this.createSQLToolStripMenuItem1_Click);
            // 
            // listBox_WaypointsCreator_CreatureGuids
            // 
            this.listBox_WaypointsCreator_CreatureGuids.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_WaypointsCreator_CreatureGuids.ContextMenuStrip = this.contextMenuStrip_WaypointsCreator_Guids;
            this.listBox_WaypointsCreator_CreatureGuids.Enabled = false;
            this.listBox_WaypointsCreator_CreatureGuids.FormattingEnabled = true;
            this.listBox_WaypointsCreator_CreatureGuids.ItemHeight = 16;
            this.listBox_WaypointsCreator_CreatureGuids.Location = new System.Drawing.Point(805, 39);
            this.listBox_WaypointsCreator_CreatureGuids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_WaypointsCreator_CreatureGuids.Name = "listBox_WaypointsCreator_CreatureGuids";
            this.listBox_WaypointsCreator_CreatureGuids.Size = new System.Drawing.Size(317, 708);
            this.listBox_WaypointsCreator_CreatureGuids.TabIndex = 27;
            this.listBox_WaypointsCreator_CreatureGuids.SelectedIndexChanged += new System.EventHandler(this.listBox_WCCreatureGuids_SelectedIndexChanged);
            // 
            // contextMenuStrip_WaypointsCreator_Guids
            // 
            this.contextMenuStrip_WaypointsCreator_Guids.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_WaypointsCreator_Guids.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeGuidsBeforeSelectedToolStripMenuItem,
            this.createRandomMovementsToolStripMenuItem,
            this.updateInhabitTypeToolStripMenuItem});
            this.contextMenuStrip_WaypointsCreator_Guids.Name = "contextMenuStrip_WC_Guids";
            this.contextMenuStrip_WaypointsCreator_Guids.Size = new System.Drawing.Size(284, 76);
            // 
            // removeGuidsBeforeSelectedToolStripMenuItem
            // 
            this.removeGuidsBeforeSelectedToolStripMenuItem.Name = "removeGuidsBeforeSelectedToolStripMenuItem";
            this.removeGuidsBeforeSelectedToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.removeGuidsBeforeSelectedToolStripMenuItem.Text = "Remove guids before selected";
            this.removeGuidsBeforeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeGuidsBeforeSelectedToolStripMenuItem_Click);
            // 
            // createRandomMovementsToolStripMenuItem
            // 
            this.createRandomMovementsToolStripMenuItem.Name = "createRandomMovementsToolStripMenuItem";
            this.createRandomMovementsToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.createRandomMovementsToolStripMenuItem.Text = "Create random movements";
            this.createRandomMovementsToolStripMenuItem.Click += new System.EventHandler(this.createRandomMovementsToolStripMenuItem_Click);
            // 
            // updateInhabitTypeToolStripMenuItem
            // 
            this.updateInhabitTypeToolStripMenuItem.Name = "updateInhabitTypeToolStripMenuItem";
            this.updateInhabitTypeToolStripMenuItem.Size = new System.Drawing.Size(283, 24);
            this.updateInhabitTypeToolStripMenuItem.Text = "Update inhabit type and speed";
            this.updateInhabitTypeToolStripMenuItem.Click += new System.EventHandler(this.updateInhabitTypeToolStripMenuItem_Click);
            // 
            // chart_WaypointsCreator_Path
            // 
            this.chart_WaypointsCreator_Path.BorderlineWidth = 0;
            this.chart_WaypointsCreator_Path.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_WaypointsCreator_Path.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart_WaypointsCreator_Path.BorderSkin.BorderWidth = 0;
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.AxisX.IsReversed = true;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea4.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX2.MajorGrid.Enabled = false;
            chartArea4.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX2.MajorTickMark.Enabled = false;
            chartArea4.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea4.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY2.MajorGrid.Enabled = false;
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY2.MajorTickMark.Enabled = false;
            chartArea4.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.CursorX.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea4.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.CursorY.IsUserEnabled = true;
            chartArea4.CursorY.IsUserSelectionEnabled = true;
            chartArea4.CursorY.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea4.Name = "ChartArea1";
            this.chart_WaypointsCreator_Path.ChartAreas.Add(chartArea4);
            this.chart_WaypointsCreator_Path.Enabled = false;
            legend4.Enabled = false;
            legend4.ForeColor = System.Drawing.Color.Transparent;
            legend4.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend4.Name = "Legend1";
            legend4.TitleForeColor = System.Drawing.Color.Transparent;
            legend4.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.chart_WaypointsCreator_Path.Legends.Add(legend4);
            this.chart_WaypointsCreator_Path.Location = new System.Drawing.Point(4, 39);
            this.chart_WaypointsCreator_Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_WaypointsCreator_Path.Name = "chart_WaypointsCreator_Path";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Path";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_WaypointsCreator_Path.Series.Add(series4);
            this.chart_WaypointsCreator_Path.Size = new System.Drawing.Size(795, 710);
            this.chart_WaypointsCreator_Path.TabIndex = 26;
            this.chart_WaypointsCreator_Path.Text = "Waypoints";
            title4.DockedToChartArea = "ChartArea1";
            title4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Path";
            title4.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chart_WaypointsCreator_Path.Titles.Add(title4);
            // 
            // toolStrip_WaypointsCreator
            // 
            this.toolStrip_WaypointsCreator.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip_WaypointsCreator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_WaypointsCreator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_WaypointsCreator_Search,
            this.toolStripTextBox_WaypointsCreator_Entry,
            this.toolStripLabel_WaypointsCreator_Entry,
            this.toolStripSeparator1,
            this.toolStripButton_WaypointsCreator_Settings,
            this.toolStripButton_WaypointsCreator_LoadSniff});
            this.toolStrip_WaypointsCreator.Location = new System.Drawing.Point(3, 2);
            this.toolStrip_WaypointsCreator.Name = "toolStrip_WaypointsCreator";
            this.toolStrip_WaypointsCreator.Size = new System.Drawing.Size(1806, 27);
            this.toolStrip_WaypointsCreator.TabIndex = 24;
            this.toolStrip_WaypointsCreator.Text = "toolStrip_WaypointsCreator";
            // 
            // toolStripButton_WaypointsCreator_Search
            // 
            this.toolStripButton_WaypointsCreator_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_WaypointsCreator_Search.Enabled = false;
            this.toolStripButton_WaypointsCreator_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WaypointsCreator_Search.Image")));
            this.toolStripButton_WaypointsCreator_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WaypointsCreator_Search.Name = "toolStripButton_WaypointsCreator_Search";
            this.toolStripButton_WaypointsCreator_Search.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton_WaypointsCreator_Search.Text = "Search";
            this.toolStripButton_WaypointsCreator_Search.ToolTipText = "Fill listbox with guids of\r\nselected entry or all entries.";
            this.toolStripButton_WaypointsCreator_Search.Click += new System.EventHandler(this.toolStripButton_WCSearch_Click);
            // 
            // toolStripTextBox_WaypointsCreator_Entry
            // 
            this.toolStripTextBox_WaypointsCreator_Entry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox_WaypointsCreator_Entry.Enabled = false;
            this.toolStripTextBox_WaypointsCreator_Entry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_WaypointsCreator_Entry.MaxLength = 40;
            this.toolStripTextBox_WaypointsCreator_Entry.Name = "toolStripTextBox_WaypointsCreator_Entry";
            this.toolStripTextBox_WaypointsCreator_Entry.Size = new System.Drawing.Size(92, 27);
            this.toolStripTextBox_WaypointsCreator_Entry.Tag = "";
            this.toolStripTextBox_WaypointsCreator_Entry.ToolTipText = "Input entry of creature or leave\r\nblank to fill listbox will all in sniff.";
            this.toolStripTextBox_WaypointsCreator_Entry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_WCSearch_Enter);
            // 
            // toolStripLabel_WaypointsCreator_Entry
            // 
            this.toolStripLabel_WaypointsCreator_Entry.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_WaypointsCreator_Entry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_WaypointsCreator_Entry.Name = "toolStripLabel_WaypointsCreator_Entry";
            this.toolStripLabel_WaypointsCreator_Entry.Size = new System.Drawing.Size(152, 24);
            this.toolStripLabel_WaypointsCreator_Entry.Text = "Creature EntryOrGuid:";
            this.toolStripLabel_WaypointsCreator_Entry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_WaypointsCreator_Settings
            // 
            this.toolStripButton_WaypointsCreator_Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_WaypointsCreator_Settings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WaypointsCreator_Settings.Image")));
            this.toolStripButton_WaypointsCreator_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WaypointsCreator_Settings.Name = "toolStripButton_WaypointsCreator_Settings";
            this.toolStripButton_WaypointsCreator_Settings.Size = new System.Drawing.Size(86, 24);
            this.toolStripButton_WaypointsCreator_Settings.Text = "Settings";
            this.toolStripButton_WaypointsCreator_Settings.ToolTipText = "Setup chart and output SQL.";
            this.toolStripButton_WaypointsCreator_Settings.Click += new System.EventHandler(this.toolStripButton_WCSettings_Click);
            // 
            // toolStripButton_WaypointsCreator_LoadSniff
            // 
            this.toolStripButton_WaypointsCreator_LoadSniff.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_WaypointsCreator_LoadSniff.Image")));
            this.toolStripButton_WaypointsCreator_LoadSniff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_WaypointsCreator_LoadSniff.Name = "toolStripButton_WaypointsCreator_LoadSniff";
            this.toolStripButton_WaypointsCreator_LoadSniff.Size = new System.Drawing.Size(112, 24);
            this.toolStripButton_WaypointsCreator_LoadSniff.Text = "Import Sniff";
            this.toolStripButton_WaypointsCreator_LoadSniff.ToolTipText = "Import a parsed wpp sniff file.";
            this.toolStripButton_WaypointsCreator_LoadSniff.Click += new System.EventHandler(this.toolStripButton_WCLoadSniff_Click);
            // 
            // tabPage_SqlOutput
            // 
            this.tabPage_SqlOutput.Controls.Add(this.textBox_SqlOutput);
            this.tabPage_SqlOutput.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SqlOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_SqlOutput.Name = "tabPage_SqlOutput";
            this.tabPage_SqlOutput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_SqlOutput.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_SqlOutput.TabIndex = 1;
            this.tabPage_SqlOutput.Text = "Sql Output";
            this.tabPage_SqlOutput.UseVisualStyleBackColor = true;
            // 
            // textBox_SqlOutput
            // 
            this.textBox_SqlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SqlOutput.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBox_SqlOutput.Location = new System.Drawing.Point(3, 2);
            this.textBox_SqlOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SqlOutput.Multiline = true;
            this.textBox_SqlOutput.Name = "textBox_SqlOutput";
            this.textBox_SqlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_SqlOutput.Size = new System.Drawing.Size(1806, 757);
            this.textBox_SqlOutput.TabIndex = 0;
            this.textBox_SqlOutput.WordWrap = false;
            // 
            // tabPage_DatabaseAdvisor
            // 
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_FindDoublePaths);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_FindDoublePaths);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_PlayerCastedSpells);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_PlayerCasterSpells);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_Output);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_GossipMenuText);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_GossipMenuText);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_SpellDestinations);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_SpellDestinations);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_AreatriggerSplines);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_AreatriggerSplines);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_QuestFlags);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_QuestFlags);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.textBox_DatabaseAdvisor_CreatureFlags);
            this.tabPage_DatabaseAdvisor.Controls.Add(this.label_DatabaseAdvisor_CreatureFlags);
            this.tabPage_DatabaseAdvisor.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DatabaseAdvisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DatabaseAdvisor.Name = "tabPage_DatabaseAdvisor";
            this.tabPage_DatabaseAdvisor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DatabaseAdvisor.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_DatabaseAdvisor.TabIndex = 2;
            this.tabPage_DatabaseAdvisor.Text = "Database Advisor";
            this.tabPage_DatabaseAdvisor.UseVisualStyleBackColor = true;
            // 
            // textBox_DatabaseAdvisor_FindDoublePaths
            // 
            this.textBox_DatabaseAdvisor_FindDoublePaths.Location = new System.Drawing.Point(7, 314);
            this.textBox_DatabaseAdvisor_FindDoublePaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_FindDoublePaths.Name = "textBox_DatabaseAdvisor_FindDoublePaths";
            this.textBox_DatabaseAdvisor_FindDoublePaths.Size = new System.Drawing.Size(124, 22);
            this.textBox_DatabaseAdvisor_FindDoublePaths.TabIndex = 14;
            this.textBox_DatabaseAdvisor_FindDoublePaths.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DatabaseAdvisor_FindDoublePaths_KeyDown);
            // 
            // label_DatabaseAdvisor_FindDoublePaths
            // 
            this.label_DatabaseAdvisor_FindDoublePaths.AutoSize = true;
            this.label_DatabaseAdvisor_FindDoublePaths.Location = new System.Drawing.Point(5, 295);
            this.label_DatabaseAdvisor_FindDoublePaths.Name = "label_DatabaseAdvisor_FindDoublePaths";
            this.label_DatabaseAdvisor_FindDoublePaths.Size = new System.Drawing.Size(121, 17);
            this.label_DatabaseAdvisor_FindDoublePaths.TabIndex = 13;
            this.label_DatabaseAdvisor_FindDoublePaths.Text = "Find double paths";
            // 
            // textBox_DatabaseAdvisor_PlayerCastedSpells
            // 
            this.textBox_DatabaseAdvisor_PlayerCastedSpells.Location = new System.Drawing.Point(7, 259);
            this.textBox_DatabaseAdvisor_PlayerCastedSpells.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_PlayerCastedSpells.Name = "textBox_DatabaseAdvisor_PlayerCastedSpells";
            this.textBox_DatabaseAdvisor_PlayerCastedSpells.Size = new System.Drawing.Size(124, 22);
            this.textBox_DatabaseAdvisor_PlayerCastedSpells.TabIndex = 12;
            this.textBox_DatabaseAdvisor_PlayerCastedSpells.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PlayerCastedSpells_KeyDown);
            // 
            // label_DatabaseAdvisor_PlayerCasterSpells
            // 
            this.label_DatabaseAdvisor_PlayerCasterSpells.AutoSize = true;
            this.label_DatabaseAdvisor_PlayerCasterSpells.Location = new System.Drawing.Point(5, 241);
            this.label_DatabaseAdvisor_PlayerCasterSpells.Name = "label_DatabaseAdvisor_PlayerCasterSpells";
            this.label_DatabaseAdvisor_PlayerCasterSpells.Size = new System.Drawing.Size(138, 17);
            this.label_DatabaseAdvisor_PlayerCasterSpells.TabIndex = 11;
            this.label_DatabaseAdvisor_PlayerCasterSpells.Text = "Player Casted Spells";
            // 
            // textBox_DatabaseAdvisor_Output
            // 
            this.textBox_DatabaseAdvisor_Output.ContextMenuStrip = this.contextMenuStrip_DatabaseAdvisor;
            this.textBox_DatabaseAdvisor_Output.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textBox_DatabaseAdvisor_Output.Location = new System.Drawing.Point(168, 2);
            this.textBox_DatabaseAdvisor_Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_Output.MaxLength = 1000000;
            this.textBox_DatabaseAdvisor_Output.Multiline = true;
            this.textBox_DatabaseAdvisor_Output.Name = "textBox_DatabaseAdvisor_Output";
            this.textBox_DatabaseAdvisor_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_DatabaseAdvisor_Output.Size = new System.Drawing.Size(1643, 752);
            this.textBox_DatabaseAdvisor_Output.TabIndex = 10;
            this.textBox_DatabaseAdvisor_Output.WordWrap = false;
            // 
            // contextMenuStrip_DatabaseAdvisor
            // 
            this.contextMenuStrip_DatabaseAdvisor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_DatabaseAdvisor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReturnPathToolStripMenuItem,
            this.recalculatePointsToolStripMenuItem,
            this.getAddonsFromSqlToolStripMenuItem});
            this.contextMenuStrip_DatabaseAdvisor.Name = "contextMenuStrip_DatabaseAdvisor";
            this.contextMenuStrip_DatabaseAdvisor.Size = new System.Drawing.Size(221, 76);
            // 
            // createReturnPathToolStripMenuItem
            // 
            this.createReturnPathToolStripMenuItem.Name = "createReturnPathToolStripMenuItem";
            this.createReturnPathToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.createReturnPathToolStripMenuItem.Text = "Create return path";
            this.createReturnPathToolStripMenuItem.Click += new System.EventHandler(this.createReturnPathToolStripMenuItem_Click);
            // 
            // recalculatePointsToolStripMenuItem
            // 
            this.recalculatePointsToolStripMenuItem.Name = "recalculatePointsToolStripMenuItem";
            this.recalculatePointsToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.recalculatePointsToolStripMenuItem.Text = "Recalculate point ids";
            this.recalculatePointsToolStripMenuItem.Click += new System.EventHandler(this.recalculatePointsToolStripMenuItem_Click);
            // 
            // getAddonsFromSqlToolStripMenuItem
            // 
            this.getAddonsFromSqlToolStripMenuItem.Name = "getAddonsFromSqlToolStripMenuItem";
            this.getAddonsFromSqlToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.getAddonsFromSqlToolStripMenuItem.Text = "Get addons from SQL";
            this.getAddonsFromSqlToolStripMenuItem.Click += new System.EventHandler(this.getAddonsFromSqlToolStripMenuItem_Click);
            // 
            // textBox_DatabaseAdvisor_GossipMenuText
            // 
            this.textBox_DatabaseAdvisor_GossipMenuText.Location = new System.Drawing.Point(6, 207);
            this.textBox_DatabaseAdvisor_GossipMenuText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_GossipMenuText.Name = "textBox_DatabaseAdvisor_GossipMenuText";
            this.textBox_DatabaseAdvisor_GossipMenuText.Size = new System.Drawing.Size(125, 22);
            this.textBox_DatabaseAdvisor_GossipMenuText.TabIndex = 9;
            this.textBox_DatabaseAdvisor_GossipMenuText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_GossipMenuText_KeyUp);
            // 
            // label_DatabaseAdvisor_GossipMenuText
            // 
            this.label_DatabaseAdvisor_GossipMenuText.AutoSize = true;
            this.label_DatabaseAdvisor_GossipMenuText.Location = new System.Drawing.Point(4, 189);
            this.label_DatabaseAdvisor_GossipMenuText.Name = "label_DatabaseAdvisor_GossipMenuText";
            this.label_DatabaseAdvisor_GossipMenuText.Size = new System.Drawing.Size(122, 17);
            this.label_DatabaseAdvisor_GossipMenuText.TabIndex = 8;
            this.label_DatabaseAdvisor_GossipMenuText.Text = "Gossip Menu Text";
            // 
            // textBox_DatabaseAdvisor_SpellDestinations
            // 
            this.textBox_DatabaseAdvisor_SpellDestinations.Location = new System.Drawing.Point(7, 158);
            this.textBox_DatabaseAdvisor_SpellDestinations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_SpellDestinations.Name = "textBox_DatabaseAdvisor_SpellDestinations";
            this.textBox_DatabaseAdvisor_SpellDestinations.Size = new System.Drawing.Size(125, 22);
            this.textBox_DatabaseAdvisor_SpellDestinations.TabIndex = 7;
            this.textBox_DatabaseAdvisor_SpellDestinations.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_SpellDestinations_KeyUp);
            // 
            // label_DatabaseAdvisor_SpellDestinations
            // 
            this.label_DatabaseAdvisor_SpellDestinations.AutoSize = true;
            this.label_DatabaseAdvisor_SpellDestinations.Location = new System.Drawing.Point(5, 140);
            this.label_DatabaseAdvisor_SpellDestinations.Name = "label_DatabaseAdvisor_SpellDestinations";
            this.label_DatabaseAdvisor_SpellDestinations.Size = new System.Drawing.Size(121, 17);
            this.label_DatabaseAdvisor_SpellDestinations.TabIndex = 6;
            this.label_DatabaseAdvisor_SpellDestinations.Text = "Spell Destinations";
            // 
            // textBox_DatabaseAdvisor_AreatriggerSplines
            // 
            this.textBox_DatabaseAdvisor_AreatriggerSplines.Location = new System.Drawing.Point(7, 114);
            this.textBox_DatabaseAdvisor_AreatriggerSplines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_AreatriggerSplines.Name = "textBox_DatabaseAdvisor_AreatriggerSplines";
            this.textBox_DatabaseAdvisor_AreatriggerSplines.Size = new System.Drawing.Size(124, 22);
            this.textBox_DatabaseAdvisor_AreatriggerSplines.TabIndex = 5;
            this.textBox_DatabaseAdvisor_AreatriggerSplines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAreatriggerSplines_KeyDown);
            // 
            // label_DatabaseAdvisor_AreatriggerSplines
            // 
            this.label_DatabaseAdvisor_AreatriggerSplines.AutoSize = true;
            this.label_DatabaseAdvisor_AreatriggerSplines.Location = new System.Drawing.Point(3, 94);
            this.label_DatabaseAdvisor_AreatriggerSplines.Name = "label_DatabaseAdvisor_AreatriggerSplines";
            this.label_DatabaseAdvisor_AreatriggerSplines.Size = new System.Drawing.Size(129, 17);
            this.label_DatabaseAdvisor_AreatriggerSplines.TabIndex = 4;
            this.label_DatabaseAdvisor_AreatriggerSplines.Text = "Areatrigger Splines";
            // 
            // textBox_DatabaseAdvisor_QuestFlags
            // 
            this.textBox_DatabaseAdvisor_QuestFlags.Location = new System.Drawing.Point(7, 68);
            this.textBox_DatabaseAdvisor_QuestFlags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_QuestFlags.Name = "textBox_DatabaseAdvisor_QuestFlags";
            this.textBox_DatabaseAdvisor_QuestFlags.Size = new System.Drawing.Size(82, 22);
            this.textBox_DatabaseAdvisor_QuestFlags.TabIndex = 3;
            this.textBox_DatabaseAdvisor_QuestFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_QuestFlags_KeyDown);
            // 
            // label_DatabaseAdvisor_QuestFlags
            // 
            this.label_DatabaseAdvisor_QuestFlags.AutoSize = true;
            this.label_DatabaseAdvisor_QuestFlags.Location = new System.Drawing.Point(5, 48);
            this.label_DatabaseAdvisor_QuestFlags.Name = "label_DatabaseAdvisor_QuestFlags";
            this.label_DatabaseAdvisor_QuestFlags.Size = new System.Drawing.Size(84, 17);
            this.label_DatabaseAdvisor_QuestFlags.TabIndex = 2;
            this.label_DatabaseAdvisor_QuestFlags.Text = "Quest Flags";
            // 
            // textBox_DatabaseAdvisor_CreatureFlags
            // 
            this.textBox_DatabaseAdvisor_CreatureFlags.Location = new System.Drawing.Point(7, 22);
            this.textBox_DatabaseAdvisor_CreatureFlags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DatabaseAdvisor_CreatureFlags.Name = "textBox_DatabaseAdvisor_CreatureFlags";
            this.textBox_DatabaseAdvisor_CreatureFlags.Size = new System.Drawing.Size(100, 22);
            this.textBox_DatabaseAdvisor_CreatureFlags.TabIndex = 1;
            this.textBox_DatabaseAdvisor_CreatureFlags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_CreatureFlags_KeyDown);
            // 
            // label_DatabaseAdvisor_CreatureFlags
            // 
            this.label_DatabaseAdvisor_CreatureFlags.AutoSize = true;
            this.label_DatabaseAdvisor_CreatureFlags.Location = new System.Drawing.Point(4, 2);
            this.label_DatabaseAdvisor_CreatureFlags.Name = "label_DatabaseAdvisor_CreatureFlags";
            this.label_DatabaseAdvisor_CreatureFlags.Size = new System.Drawing.Size(101, 17);
            this.label_DatabaseAdvisor_CreatureFlags.TabIndex = 0;
            this.label_DatabaseAdvisor_CreatureFlags.Text = "Creature Flags";
            // 
            // tabPage_DoubleSpawnsRemover
            // 
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.label_DoubleSpawnsRemover_GameobjectsRemoved);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.checkBox_DoubleSpawnsRemover_Gameobjects);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.checkBox_DoubleSpawnsRemover_Creatures);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.label_DoubleSpawnsRemover_CreaturesRemoved);
            this.tabPage_DoubleSpawnsRemover.Controls.Add(this.button_DoubleSpawnsRemover_ImportFile);
            this.tabPage_DoubleSpawnsRemover.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DoubleSpawnsRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DoubleSpawnsRemover.Name = "tabPage_DoubleSpawnsRemover";
            this.tabPage_DoubleSpawnsRemover.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_DoubleSpawnsRemover.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_DoubleSpawnsRemover.TabIndex = 3;
            this.tabPage_DoubleSpawnsRemover.Text = "Double-Spawns Remover";
            this.tabPage_DoubleSpawnsRemover.UseVisualStyleBackColor = true;
            // 
            // label_DoubleSpawnsRemover_GameobjectsRemoved
            // 
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.AutoSize = true;
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.Location = new System.Drawing.Point(439, 106);
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.Name = "label_DoubleSpawnsRemover_GameobjectsRemoved";
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.Size = new System.Drawing.Size(169, 17);
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.TabIndex = 4;
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.Text = "No gameobjects removed";
            this.label_DoubleSpawnsRemover_GameobjectsRemoved.Visible = false;
            // 
            // checkBox_DoubleSpawnsRemover_Gameobjects
            // 
            this.checkBox_DoubleSpawnsRemover_Gameobjects.AutoSize = true;
            this.checkBox_DoubleSpawnsRemover_Gameobjects.Checked = true;
            this.checkBox_DoubleSpawnsRemover_Gameobjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DoubleSpawnsRemover_Gameobjects.Location = new System.Drawing.Point(713, 4);
            this.checkBox_DoubleSpawnsRemover_Gameobjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_DoubleSpawnsRemover_Gameobjects.Name = "checkBox_DoubleSpawnsRemover_Gameobjects";
            this.checkBox_DoubleSpawnsRemover_Gameobjects.Size = new System.Drawing.Size(113, 21);
            this.checkBox_DoubleSpawnsRemover_Gameobjects.TabIndex = 3;
            this.checkBox_DoubleSpawnsRemover_Gameobjects.Text = "Gameobjects";
            this.checkBox_DoubleSpawnsRemover_Gameobjects.UseVisualStyleBackColor = true;
            this.checkBox_DoubleSpawnsRemover_Gameobjects.CheckedChanged += new System.EventHandler(this.checkBox_GameobjectsRemover_CheckedChanged);
            // 
            // checkBox_DoubleSpawnsRemover_Creatures
            // 
            this.checkBox_DoubleSpawnsRemover_Creatures.AutoSize = true;
            this.checkBox_DoubleSpawnsRemover_Creatures.Checked = true;
            this.checkBox_DoubleSpawnsRemover_Creatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DoubleSpawnsRemover_Creatures.Location = new System.Drawing.Point(622, 4);
            this.checkBox_DoubleSpawnsRemover_Creatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_DoubleSpawnsRemover_Creatures.Name = "checkBox_DoubleSpawnsRemover_Creatures";
            this.checkBox_DoubleSpawnsRemover_Creatures.Size = new System.Drawing.Size(92, 21);
            this.checkBox_DoubleSpawnsRemover_Creatures.TabIndex = 2;
            this.checkBox_DoubleSpawnsRemover_Creatures.Text = "Creatures";
            this.checkBox_DoubleSpawnsRemover_Creatures.UseVisualStyleBackColor = true;
            this.checkBox_DoubleSpawnsRemover_Creatures.CheckedChanged += new System.EventHandler(this.checkBox_CreaturesRemover_CheckedChanged);
            // 
            // label_DoubleSpawnsRemover_CreaturesRemoved
            // 
            this.label_DoubleSpawnsRemover_CreaturesRemoved.AutoSize = true;
            this.label_DoubleSpawnsRemover_CreaturesRemoved.Location = new System.Drawing.Point(439, 90);
            this.label_DoubleSpawnsRemover_CreaturesRemoved.Name = "label_DoubleSpawnsRemover_CreaturesRemoved";
            this.label_DoubleSpawnsRemover_CreaturesRemoved.Size = new System.Drawing.Size(149, 17);
            this.label_DoubleSpawnsRemover_CreaturesRemoved.TabIndex = 1;
            this.label_DoubleSpawnsRemover_CreaturesRemoved.Text = "No creatures removed";
            this.label_DoubleSpawnsRemover_CreaturesRemoved.Visible = false;
            // 
            // button_DoubleSpawnsRemover_ImportFile
            // 
            this.button_DoubleSpawnsRemover_ImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DoubleSpawnsRemover_ImportFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_DoubleSpawnsRemover_ImportFile.FlatAppearance.BorderSize = 5;
            this.button_DoubleSpawnsRemover_ImportFile.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DoubleSpawnsRemover_ImportFile.Location = new System.Drawing.Point(622, 23);
            this.button_DoubleSpawnsRemover_ImportFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DoubleSpawnsRemover_ImportFile.Name = "button_DoubleSpawnsRemover_ImportFile";
            this.button_DoubleSpawnsRemover_ImportFile.Size = new System.Drawing.Size(196, 34);
            this.button_DoubleSpawnsRemover_ImportFile.TabIndex = 0;
            this.button_DoubleSpawnsRemover_ImportFile.Text = "Import File";
            this.button_DoubleSpawnsRemover_ImportFile.UseVisualStyleBackColor = true;
            this.button_DoubleSpawnsRemover_ImportFile.Click += new System.EventHandler(this.button_ImportFile_Click);
            // 
            // tabPage_CoreScriptTemplates
            // 
            this.tabPage_CoreScriptTemplates.Controls.Add(this.Core_script_creatore_preview);
            this.tabPage_CoreScriptTemplates.Controls.Add(this.treeView_CoreScriptTemplates_HookBodies);
            this.tabPage_CoreScriptTemplates.Controls.Add(this.label_CoreScriptTemplates_ScriptType);
            this.tabPage_CoreScriptTemplates.Controls.Add(this.comboBox_CoreScriptTemplates_ScriptType);
            this.tabPage_CoreScriptTemplates.Controls.Add(this.label_CoreScriptTemplates_ObjectId);
            this.tabPage_CoreScriptTemplates.Controls.Add(this.textBox_CoreScriptTemplates_ObjectId);
            this.tabPage_CoreScriptTemplates.Controls.Add(this.listBox_CoreScriptTemplates_Hooks);
            this.tabPage_CoreScriptTemplates.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CoreScriptTemplates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_CoreScriptTemplates.Name = "tabPage_CoreScriptTemplates";
            this.tabPage_CoreScriptTemplates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_CoreScriptTemplates.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_CoreScriptTemplates.TabIndex = 5;
            this.tabPage_CoreScriptTemplates.Text = "Core Script Templates";
            this.tabPage_CoreScriptTemplates.UseVisualStyleBackColor = true;
            // 
            // treeView_CoreScriptTemplates_HookBodies
            // 
            this.treeView_CoreScriptTemplates_HookBodies.CheckBoxes = true;
            this.treeView_CoreScriptTemplates_HookBodies.Location = new System.Drawing.Point(215, 39);
            this.treeView_CoreScriptTemplates_HookBodies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_CoreScriptTemplates_HookBodies.Name = "treeView_CoreScriptTemplates_HookBodies";
            this.treeView_CoreScriptTemplates_HookBodies.Size = new System.Drawing.Size(223, 708);
            this.treeView_CoreScriptTemplates_HookBodies.TabIndex = 6;
            this.treeView_CoreScriptTemplates_HookBodies.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_CoreScriptTemplates_HookBodies_AfterCheck);
            // 
            // label_CoreScriptTemplates_ScriptType
            // 
            this.label_CoreScriptTemplates_ScriptType.AutoSize = true;
            this.label_CoreScriptTemplates_ScriptType.Location = new System.Drawing.Point(5, 10);
            this.label_CoreScriptTemplates_ScriptType.Name = "label_CoreScriptTemplates_ScriptType";
            this.label_CoreScriptTemplates_ScriptType.Size = new System.Drawing.Size(84, 17);
            this.label_CoreScriptTemplates_ScriptType.TabIndex = 5;
            this.label_CoreScriptTemplates_ScriptType.Text = "Script Type:";
            // 
            // comboBox_CoreScriptTemplates_ScriptType
            // 
            this.comboBox_CoreScriptTemplates_ScriptType.Items.AddRange(new object[] {
            "Creature",
            "GameObject",
            "AreaTrigger",
            "Spell",
            "PlayerScript"});
            this.comboBox_CoreScriptTemplates_ScriptType.Location = new System.Drawing.Point(92, 7);
            this.comboBox_CoreScriptTemplates_ScriptType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_CoreScriptTemplates_ScriptType.Name = "comboBox_CoreScriptTemplates_ScriptType";
            this.comboBox_CoreScriptTemplates_ScriptType.Size = new System.Drawing.Size(108, 24);
            this.comboBox_CoreScriptTemplates_ScriptType.TabIndex = 1;
            this.comboBox_CoreScriptTemplates_ScriptType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label_CoreScriptTemplates_ObjectId
            // 
            this.label_CoreScriptTemplates_ObjectId.AutoSize = true;
            this.label_CoreScriptTemplates_ObjectId.Location = new System.Drawing.Point(233, 10);
            this.label_CoreScriptTemplates_ObjectId.Name = "label_CoreScriptTemplates_ObjectId";
            this.label_CoreScriptTemplates_ObjectId.Size = new System.Drawing.Size(106, 17);
            this.label_CoreScriptTemplates_ObjectId.TabIndex = 4;
            this.label_CoreScriptTemplates_ObjectId.Text = "Enter Object Id:";
            // 
            // textBox_CoreScriptTemplates_ObjectId
            // 
            this.textBox_CoreScriptTemplates_ObjectId.Enabled = false;
            this.textBox_CoreScriptTemplates_ObjectId.Location = new System.Drawing.Point(345, 7);
            this.textBox_CoreScriptTemplates_ObjectId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CoreScriptTemplates_ObjectId.MaxLength = 6;
            this.textBox_CoreScriptTemplates_ObjectId.Name = "textBox_CoreScriptTemplates_ObjectId";
            this.textBox_CoreScriptTemplates_ObjectId.Size = new System.Drawing.Size(63, 22);
            this.textBox_CoreScriptTemplates_ObjectId.TabIndex = 2;
            this.textBox_CoreScriptTemplates_ObjectId.TextChanged += new System.EventHandler(this.textBox_CoreScriptTemplates_ObjectId_TextChanged);
            this.textBox_CoreScriptTemplates_ObjectId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_CoreScriptTemplates_Enter);
            // 
            // listBox_CoreScriptTemplates_Hooks
            // 
            this.listBox_CoreScriptTemplates_Hooks.ItemHeight = 16;
            this.listBox_CoreScriptTemplates_Hooks.Location = new System.Drawing.Point(7, 39);
            this.listBox_CoreScriptTemplates_Hooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_CoreScriptTemplates_Hooks.Name = "listBox_CoreScriptTemplates_Hooks";
            this.listBox_CoreScriptTemplates_Hooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_CoreScriptTemplates_Hooks.Size = new System.Drawing.Size(193, 708);
            this.listBox_CoreScriptTemplates_Hooks.TabIndex = 0;
            this.listBox_CoreScriptTemplates_Hooks.SelectedIndexChanged += new System.EventHandler(this.ListBox_CoreScriptTemplates_SelectedIndexChanged);
            // 
            // tabPage_Achievements
            // 
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_ModifierTreeChildNodes);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_ModifierTreeChildNodes);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_ModifierTrees);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_ModifierTrees);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_Criterias);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_Criterias);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTreeAmount);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTreeChildNodes);
            this.tabPage_Achievements.Controls.Add(this.label_Achievement_CriteriaTreeOperator);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTreeName);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_CriteriaTreeId);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_AchievementFlags);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_AchievementFaction);
            this.tabPage_Achievements.Controls.Add(this.treeView_Achievements_ChildNodes);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_AchievementName);
            this.tabPage_Achievements.Controls.Add(this.textBox_Achievements_AchievementId);
            this.tabPage_Achievements.Controls.Add(this.label_Achievements_AchievementId);
            this.tabPage_Achievements.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Achievements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Achievements.Name = "tabPage_Achievements";
            this.tabPage_Achievements.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Achievements.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_Achievements.TabIndex = 6;
            this.tabPage_Achievements.Text = "Achievements";
            this.tabPage_Achievements.UseVisualStyleBackColor = true;
            // 
            // label_Achievements_ModifierTreeChildNodes
            // 
            this.label_Achievements_ModifierTreeChildNodes.AutoSize = true;
            this.label_Achievements_ModifierTreeChildNodes.Location = new System.Drawing.Point(1490, 180);
            this.label_Achievements_ModifierTreeChildNodes.Name = "label_Achievements_ModifierTreeChildNodes";
            this.label_Achievements_ModifierTreeChildNodes.Size = new System.Drawing.Size(176, 17);
            this.label_Achievements_ModifierTreeChildNodes.TabIndex = 16;
            this.label_Achievements_ModifierTreeChildNodes.Text = "Modifier Tree Child Nodes:";
            // 
            // treeView_Achievements_ModifierTreeChildNodes
            // 
            this.treeView_Achievements_ModifierTreeChildNodes.Location = new System.Drawing.Point(1353, 201);
            this.treeView_Achievements_ModifierTreeChildNodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_ModifierTreeChildNodes.Name = "treeView_Achievements_ModifierTreeChildNodes";
            this.treeView_Achievements_ModifierTreeChildNodes.Size = new System.Drawing.Size(445, 544);
            this.treeView_Achievements_ModifierTreeChildNodes.TabIndex = 15;
            // 
            // label_Achievements_ModifierTrees
            // 
            this.label_Achievements_ModifierTrees.AutoSize = true;
            this.label_Achievements_ModifierTrees.Location = new System.Drawing.Point(1076, 181);
            this.label_Achievements_ModifierTrees.Name = "label_Achievements_ModifierTrees";
            this.label_Achievements_ModifierTrees.Size = new System.Drawing.Size(103, 17);
            this.label_Achievements_ModifierTrees.TabIndex = 14;
            this.label_Achievements_ModifierTrees.Text = "Modifier Trees:";
            // 
            // treeView_Achievements_ModifierTrees
            // 
            this.treeView_Achievements_ModifierTrees.Location = new System.Drawing.Point(904, 201);
            this.treeView_Achievements_ModifierTrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_ModifierTrees.Name = "treeView_Achievements_ModifierTrees";
            this.treeView_Achievements_ModifierTrees.Size = new System.Drawing.Size(445, 544);
            this.treeView_Achievements_ModifierTrees.TabIndex = 13;
            this.treeView_Achievements_ModifierTrees.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ModifierTrees_AfterCollapse);
            this.treeView_Achievements_ModifierTrees.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ModifierTrees_AfterExpand);
            // 
            // label_Achievements_Criterias
            // 
            this.label_Achievements_Criterias.AutoSize = true;
            this.label_Achievements_Criterias.Location = new System.Drawing.Point(645, 180);
            this.label_Achievements_Criterias.Name = "label_Achievements_Criterias";
            this.label_Achievements_Criterias.Size = new System.Drawing.Size(64, 17);
            this.label_Achievements_Criterias.TabIndex = 12;
            this.label_Achievements_Criterias.Text = "Criterias:";
            // 
            // treeView_Achievements_Criterias
            // 
            this.treeView_Achievements_Criterias.Location = new System.Drawing.Point(455, 201);
            this.treeView_Achievements_Criterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_Criterias.Name = "treeView_Achievements_Criterias";
            this.treeView_Achievements_Criterias.Size = new System.Drawing.Size(445, 544);
            this.treeView_Achievements_Criterias.TabIndex = 11;
            this.treeView_Achievements_Criterias.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_Criterias_AfterCollapse);
            this.treeView_Achievements_Criterias.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_Criterias_AfterExpand);
            // 
            // label_Achievements_CriteriaTreeAmount
            // 
            this.label_Achievements_CriteriaTreeAmount.AutoSize = true;
            this.label_Achievements_CriteriaTreeAmount.Location = new System.Drawing.Point(5, 135);
            this.label_Achievements_CriteriaTreeAmount.Name = "label_Achievements_CriteriaTreeAmount";
            this.label_Achievements_CriteriaTreeAmount.Size = new System.Drawing.Size(143, 17);
            this.label_Achievements_CriteriaTreeAmount.TabIndex = 10;
            this.label_Achievements_CriteriaTreeAmount.Text = "CriteriaTree Amount: ";
            // 
            // label_Achievements_CriteriaTreeChildNodes
            // 
            this.label_Achievements_CriteriaTreeChildNodes.AutoSize = true;
            this.label_Achievements_CriteriaTreeChildNodes.Location = new System.Drawing.Point(142, 182);
            this.label_Achievements_CriteriaTreeChildNodes.Name = "label_Achievements_CriteriaTreeChildNodes";
            this.label_Achievements_CriteriaTreeChildNodes.Size = new System.Drawing.Size(171, 17);
            this.label_Achievements_CriteriaTreeChildNodes.TabIndex = 9;
            this.label_Achievements_CriteriaTreeChildNodes.Text = "Criteria Tree Child Nodes:";
            // 
            // label_Achievement_CriteriaTreeOperator
            // 
            this.label_Achievement_CriteriaTreeOperator.AutoSize = true;
            this.label_Achievement_CriteriaTreeOperator.Location = new System.Drawing.Point(5, 156);
            this.label_Achievement_CriteriaTreeOperator.Name = "label_Achievement_CriteriaTreeOperator";
            this.label_Achievement_CriteriaTreeOperator.Size = new System.Drawing.Size(152, 17);
            this.label_Achievement_CriteriaTreeOperator.TabIndex = 8;
            this.label_Achievement_CriteriaTreeOperator.Text = "CriteriaTree Operator: ";
            // 
            // label_Achievements_CriteriaTreeName
            // 
            this.label_Achievements_CriteriaTreeName.AutoSize = true;
            this.label_Achievements_CriteriaTreeName.Location = new System.Drawing.Point(4, 116);
            this.label_Achievements_CriteriaTreeName.Name = "label_Achievements_CriteriaTreeName";
            this.label_Achievements_CriteriaTreeName.Size = new System.Drawing.Size(132, 17);
            this.label_Achievements_CriteriaTreeName.TabIndex = 7;
            this.label_Achievements_CriteriaTreeName.Text = "CriteriaTree Name: ";
            // 
            // label_Achievements_CriteriaTreeId
            // 
            this.label_Achievements_CriteriaTreeId.AutoSize = true;
            this.label_Achievements_CriteriaTreeId.Location = new System.Drawing.Point(5, 96);
            this.label_Achievements_CriteriaTreeId.Name = "label_Achievements_CriteriaTreeId";
            this.label_Achievements_CriteriaTreeId.Size = new System.Drawing.Size(106, 17);
            this.label_Achievements_CriteriaTreeId.TabIndex = 6;
            this.label_Achievements_CriteriaTreeId.Text = "CriteriaTree Id: ";
            // 
            // label_Achievements_AchievementFlags
            // 
            this.label_Achievements_AchievementFlags.AutoSize = true;
            this.label_Achievements_AchievementFlags.Location = new System.Drawing.Point(5, 68);
            this.label_Achievements_AchievementFlags.Name = "label_Achievements_AchievementFlags";
            this.label_Achievements_AchievementFlags.Size = new System.Drawing.Size(135, 17);
            this.label_Achievements_AchievementFlags.TabIndex = 5;
            this.label_Achievements_AchievementFlags.Text = "Achievement Flags: ";
            // 
            // label_Achievements_AchievementFaction
            // 
            this.label_Achievements_AchievementFaction.AutoSize = true;
            this.label_Achievements_AchievementFaction.Location = new System.Drawing.Point(4, 48);
            this.label_Achievements_AchievementFaction.Name = "label_Achievements_AchievementFaction";
            this.label_Achievements_AchievementFaction.Size = new System.Drawing.Size(147, 17);
            this.label_Achievements_AchievementFaction.TabIndex = 4;
            this.label_Achievements_AchievementFaction.Text = "Achievement Faction: ";
            // 
            // treeView_Achievements_ChildNodes
            // 
            this.treeView_Achievements_ChildNodes.Location = new System.Drawing.Point(4, 201);
            this.treeView_Achievements_ChildNodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_Achievements_ChildNodes.Name = "treeView_Achievements_ChildNodes";
            this.treeView_Achievements_ChildNodes.Size = new System.Drawing.Size(445, 544);
            this.treeView_Achievements_ChildNodes.TabIndex = 3;
            this.treeView_Achievements_ChildNodes.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ChildNodes_AfterCollapse);
            this.treeView_Achievements_ChildNodes.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Achievements_ChildNodes_AfterExpand);
            // 
            // label_Achievements_AchievementName
            // 
            this.label_Achievements_AchievementName.AutoSize = true;
            this.label_Achievements_AchievementName.Location = new System.Drawing.Point(4, 28);
            this.label_Achievements_AchievementName.Name = "label_Achievements_AchievementName";
            this.label_Achievements_AchievementName.Size = new System.Drawing.Size(138, 17);
            this.label_Achievements_AchievementName.TabIndex = 2;
            this.label_Achievements_AchievementName.Text = "Achievement Name: ";
            // 
            // textBox_Achievements_AchievementId
            // 
            this.textBox_Achievements_AchievementId.Location = new System.Drawing.Point(116, 2);
            this.textBox_Achievements_AchievementId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Achievements_AchievementId.Name = "textBox_Achievements_AchievementId";
            this.textBox_Achievements_AchievementId.Size = new System.Drawing.Size(89, 22);
            this.textBox_Achievements_AchievementId.TabIndex = 1;
            this.textBox_Achievements_AchievementId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxAchievements_Id_KeyUp);
            // 
            // label_Achievements_AchievementId
            // 
            this.label_Achievements_AchievementId.AutoSize = true;
            this.label_Achievements_AchievementId.Location = new System.Drawing.Point(4, 6);
            this.label_Achievements_AchievementId.Name = "label_Achievements_AchievementId";
            this.label_Achievements_AchievementId.Size = new System.Drawing.Size(108, 17);
            this.label_Achievements_AchievementId.TabIndex = 0;
            this.label_Achievements_AchievementId.Text = "Achievement Id:";
            // 
            // tabPage_ConditionsCreator
            // 
            this.tabPage_ConditionsCreator.Controls.Add(this.button_ConditionsCreator_ClearConditions);
            this.tabPage_ConditionsCreator.Controls.Add(this.button_ConditionsCreator_AddCondition);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_Output);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ScriptName);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_NegativeCondition);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionValue3);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionValue2);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionValue1);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_ScriptName);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_NegativeCondition);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_ConditionValue3);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_ConditionValue2);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_ConditionValue1);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_ConditionTarget);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionTarget);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionType);
            this.tabPage_ConditionsCreator.Controls.Add(this.comboBox_ConditionsCreator_ConditionType);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_ElseGroup);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ElseGroup);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_SourceId);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_SourceId);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_SourceEntry);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_SourceEntry);
            this.tabPage_ConditionsCreator.Controls.Add(this.textBox_ConditionsCreator_SourceGroup);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionSourceGroup);
            this.tabPage_ConditionsCreator.Controls.Add(this.comboBox_ConditionsCreator_ConditionSourceType);
            this.tabPage_ConditionsCreator.Controls.Add(this.label_ConditionsCreator_ConditionSourceType);
            this.tabPage_ConditionsCreator.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ConditionsCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_ConditionsCreator.Name = "tabPage_ConditionsCreator";
            this.tabPage_ConditionsCreator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_ConditionsCreator.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_ConditionsCreator.TabIndex = 7;
            this.tabPage_ConditionsCreator.Text = "Conditions Creator";
            this.tabPage_ConditionsCreator.UseVisualStyleBackColor = true;
            // 
            // button_ConditionsCreator_ClearConditions
            // 
            this.button_ConditionsCreator_ClearConditions.Enabled = false;
            this.button_ConditionsCreator_ClearConditions.Location = new System.Drawing.Point(306, 327);
            this.button_ConditionsCreator_ClearConditions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ConditionsCreator_ClearConditions.Name = "button_ConditionsCreator_ClearConditions";
            this.button_ConditionsCreator_ClearConditions.Size = new System.Drawing.Size(123, 25);
            this.button_ConditionsCreator_ClearConditions.TabIndex = 26;
            this.button_ConditionsCreator_ClearConditions.Text = "Clear Conditions";
            this.button_ConditionsCreator_ClearConditions.UseVisualStyleBackColor = true;
            this.button_ConditionsCreator_ClearConditions.Click += new System.EventHandler(this.button_ClearConditions_Click);
            // 
            // button_ConditionsCreator_AddCondition
            // 
            this.button_ConditionsCreator_AddCondition.Enabled = false;
            this.button_ConditionsCreator_AddCondition.Location = new System.Drawing.Point(11, 327);
            this.button_ConditionsCreator_AddCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ConditionsCreator_AddCondition.Name = "button_ConditionsCreator_AddCondition";
            this.button_ConditionsCreator_AddCondition.Size = new System.Drawing.Size(112, 25);
            this.button_ConditionsCreator_AddCondition.TabIndex = 25;
            this.button_ConditionsCreator_AddCondition.Text = "Add Condition";
            this.button_ConditionsCreator_AddCondition.UseVisualStyleBackColor = true;
            this.button_ConditionsCreator_AddCondition.Click += new System.EventHandler(this.button_AddCondition_Click);
            // 
            // textBox_ConditionsCreator_Output
            // 
            this.textBox_ConditionsCreator_Output.Enabled = false;
            this.textBox_ConditionsCreator_Output.Location = new System.Drawing.Point(868, 5);
            this.textBox_ConditionsCreator_Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_Output.Multiline = true;
            this.textBox_ConditionsCreator_Output.Name = "textBox_ConditionsCreator_Output";
            this.textBox_ConditionsCreator_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ConditionsCreator_Output.Size = new System.Drawing.Size(940, 750);
            this.textBox_ConditionsCreator_Output.TabIndex = 24;
            // 
            // label_ConditionsCreator_ScriptName
            // 
            this.label_ConditionsCreator_ScriptName.AutoSize = true;
            this.label_ConditionsCreator_ScriptName.Location = new System.Drawing.Point(7, 293);
            this.label_ConditionsCreator_ScriptName.Name = "label_ConditionsCreator_ScriptName";
            this.label_ConditionsCreator_ScriptName.Size = new System.Drawing.Size(85, 17);
            this.label_ConditionsCreator_ScriptName.TabIndex = 23;
            this.label_ConditionsCreator_ScriptName.Text = "ScriptName:";
            // 
            // label_ConditionsCreator_NegativeCondition
            // 
            this.label_ConditionsCreator_NegativeCondition.AutoSize = true;
            this.label_ConditionsCreator_NegativeCondition.Location = new System.Drawing.Point(7, 267);
            this.label_ConditionsCreator_NegativeCondition.Name = "label_ConditionsCreator_NegativeCondition";
            this.label_ConditionsCreator_NegativeCondition.Size = new System.Drawing.Size(131, 17);
            this.label_ConditionsCreator_NegativeCondition.TabIndex = 22;
            this.label_ConditionsCreator_NegativeCondition.Text = "Negative Condition:";
            // 
            // label_ConditionsCreator_ConditionValue3
            // 
            this.label_ConditionsCreator_ConditionValue3.AutoSize = true;
            this.label_ConditionsCreator_ConditionValue3.Location = new System.Drawing.Point(7, 242);
            this.label_ConditionsCreator_ConditionValue3.Name = "label_ConditionsCreator_ConditionValue3";
            this.label_ConditionsCreator_ConditionValue3.Size = new System.Drawing.Size(123, 17);
            this.label_ConditionsCreator_ConditionValue3.TabIndex = 21;
            this.label_ConditionsCreator_ConditionValue3.Text = "Condition Value 3:";
            // 
            // label_ConditionsCreator_ConditionValue2
            // 
            this.label_ConditionsCreator_ConditionValue2.AutoSize = true;
            this.label_ConditionsCreator_ConditionValue2.Location = new System.Drawing.Point(7, 215);
            this.label_ConditionsCreator_ConditionValue2.Name = "label_ConditionsCreator_ConditionValue2";
            this.label_ConditionsCreator_ConditionValue2.Size = new System.Drawing.Size(123, 17);
            this.label_ConditionsCreator_ConditionValue2.TabIndex = 20;
            this.label_ConditionsCreator_ConditionValue2.Text = "Condition Value 2:";
            // 
            // label_ConditionsCreator_ConditionValue1
            // 
            this.label_ConditionsCreator_ConditionValue1.AutoSize = true;
            this.label_ConditionsCreator_ConditionValue1.Location = new System.Drawing.Point(7, 190);
            this.label_ConditionsCreator_ConditionValue1.Name = "label_ConditionsCreator_ConditionValue1";
            this.label_ConditionsCreator_ConditionValue1.Size = new System.Drawing.Size(123, 17);
            this.label_ConditionsCreator_ConditionValue1.TabIndex = 19;
            this.label_ConditionsCreator_ConditionValue1.Text = "Condition Value 1:";
            // 
            // textBox_ConditionsCreator_ScriptName
            // 
            this.textBox_ConditionsCreator_ScriptName.Enabled = false;
            this.textBox_ConditionsCreator_ScriptName.Location = new System.Drawing.Point(142, 290);
            this.textBox_ConditionsCreator_ScriptName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_ScriptName.MaxLength = 50;
            this.textBox_ConditionsCreator_ScriptName.Name = "textBox_ConditionsCreator_ScriptName";
            this.textBox_ConditionsCreator_ScriptName.Size = new System.Drawing.Size(285, 22);
            this.textBox_ConditionsCreator_ScriptName.TabIndex = 18;
            // 
            // textBox_ConditionsCreator_NegativeCondition
            // 
            this.textBox_ConditionsCreator_NegativeCondition.Enabled = false;
            this.textBox_ConditionsCreator_NegativeCondition.Location = new System.Drawing.Point(142, 265);
            this.textBox_ConditionsCreator_NegativeCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_NegativeCondition.MaxLength = 1;
            this.textBox_ConditionsCreator_NegativeCondition.Name = "textBox_ConditionsCreator_NegativeCondition";
            this.textBox_ConditionsCreator_NegativeCondition.Size = new System.Drawing.Size(27, 22);
            this.textBox_ConditionsCreator_NegativeCondition.TabIndex = 17;
            this.textBox_ConditionsCreator_NegativeCondition.Text = "0";
            this.textBox_ConditionsCreator_NegativeCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ConditionsCreator_ConditionValue3
            // 
            this.textBox_ConditionsCreator_ConditionValue3.Enabled = false;
            this.textBox_ConditionsCreator_ConditionValue3.Location = new System.Drawing.Point(142, 238);
            this.textBox_ConditionsCreator_ConditionValue3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_ConditionValue3.MaxLength = 6;
            this.textBox_ConditionsCreator_ConditionValue3.Name = "textBox_ConditionsCreator_ConditionValue3";
            this.textBox_ConditionsCreator_ConditionValue3.Size = new System.Drawing.Size(89, 22);
            this.textBox_ConditionsCreator_ConditionValue3.TabIndex = 16;
            // 
            // textBox_ConditionsCreator_ConditionValue2
            // 
            this.textBox_ConditionsCreator_ConditionValue2.Enabled = false;
            this.textBox_ConditionsCreator_ConditionValue2.Location = new System.Drawing.Point(142, 214);
            this.textBox_ConditionsCreator_ConditionValue2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_ConditionValue2.MaxLength = 6;
            this.textBox_ConditionsCreator_ConditionValue2.Name = "textBox_ConditionsCreator_ConditionValue2";
            this.textBox_ConditionsCreator_ConditionValue2.Size = new System.Drawing.Size(89, 22);
            this.textBox_ConditionsCreator_ConditionValue2.TabIndex = 15;
            // 
            // textBox_ConditionsCreator_ConditionValue1
            // 
            this.textBox_ConditionsCreator_ConditionValue1.Enabled = false;
            this.textBox_ConditionsCreator_ConditionValue1.Location = new System.Drawing.Point(142, 188);
            this.textBox_ConditionsCreator_ConditionValue1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_ConditionValue1.MaxLength = 6;
            this.textBox_ConditionsCreator_ConditionValue1.Name = "textBox_ConditionsCreator_ConditionValue1";
            this.textBox_ConditionsCreator_ConditionValue1.Size = new System.Drawing.Size(89, 22);
            this.textBox_ConditionsCreator_ConditionValue1.TabIndex = 14;
            // 
            // textBox_ConditionsCreator_ConditionTarget
            // 
            this.textBox_ConditionsCreator_ConditionTarget.Enabled = false;
            this.textBox_ConditionsCreator_ConditionTarget.Location = new System.Drawing.Point(142, 162);
            this.textBox_ConditionsCreator_ConditionTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_ConditionTarget.MaxLength = 1;
            this.textBox_ConditionsCreator_ConditionTarget.Name = "textBox_ConditionsCreator_ConditionTarget";
            this.textBox_ConditionsCreator_ConditionTarget.Size = new System.Drawing.Size(27, 22);
            this.textBox_ConditionsCreator_ConditionTarget.TabIndex = 13;
            this.textBox_ConditionsCreator_ConditionTarget.Text = "0";
            this.textBox_ConditionsCreator_ConditionTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ConditionsCreator_ConditionTarget
            // 
            this.label_ConditionsCreator_ConditionTarget.AutoSize = true;
            this.label_ConditionsCreator_ConditionTarget.Location = new System.Drawing.Point(7, 165);
            this.label_ConditionsCreator_ConditionTarget.Name = "label_ConditionsCreator_ConditionTarget";
            this.label_ConditionsCreator_ConditionTarget.Size = new System.Drawing.Size(117, 17);
            this.label_ConditionsCreator_ConditionTarget.TabIndex = 12;
            this.label_ConditionsCreator_ConditionTarget.Text = "Condition Target:";
            // 
            // label_ConditionsCreator_ConditionType
            // 
            this.label_ConditionsCreator_ConditionType.AutoSize = true;
            this.label_ConditionsCreator_ConditionType.Location = new System.Drawing.Point(7, 138);
            this.label_ConditionsCreator_ConditionType.Name = "label_ConditionsCreator_ConditionType";
            this.label_ConditionsCreator_ConditionType.Size = new System.Drawing.Size(107, 17);
            this.label_ConditionsCreator_ConditionType.TabIndex = 11;
            this.label_ConditionsCreator_ConditionType.Text = "Condition Type:";
            // 
            // comboBox_ConditionsCreator_ConditionType
            // 
            this.comboBox_ConditionsCreator_ConditionType.Enabled = false;
            this.comboBox_ConditionsCreator_ConditionType.FormattingEnabled = true;
            this.comboBox_ConditionsCreator_ConditionType.Location = new System.Drawing.Point(142, 135);
            this.comboBox_ConditionsCreator_ConditionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ConditionsCreator_ConditionType.Name = "comboBox_ConditionsCreator_ConditionType";
            this.comboBox_ConditionsCreator_ConditionType.Size = new System.Drawing.Size(285, 24);
            this.comboBox_ConditionsCreator_ConditionType.TabIndex = 10;
            this.comboBox_ConditionsCreator_ConditionType.DropDown += new System.EventHandler(this.comboBox_ConditionType_DropDown);
            this.comboBox_ConditionsCreator_ConditionType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ConditionType_SelectedIndexChanged);
            // 
            // textBox_ConditionsCreator_ElseGroup
            // 
            this.textBox_ConditionsCreator_ElseGroup.Enabled = false;
            this.textBox_ConditionsCreator_ElseGroup.Location = new System.Drawing.Point(142, 110);
            this.textBox_ConditionsCreator_ElseGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_ElseGroup.MaxLength = 2;
            this.textBox_ConditionsCreator_ElseGroup.Name = "textBox_ConditionsCreator_ElseGroup";
            this.textBox_ConditionsCreator_ElseGroup.Size = new System.Drawing.Size(45, 22);
            this.textBox_ConditionsCreator_ElseGroup.TabIndex = 9;
            this.textBox_ConditionsCreator_ElseGroup.Text = "0";
            this.textBox_ConditionsCreator_ElseGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ConditionsCreator_ElseGroup
            // 
            this.label_ConditionsCreator_ElseGroup.AutoSize = true;
            this.label_ConditionsCreator_ElseGroup.Location = new System.Drawing.Point(7, 114);
            this.label_ConditionsCreator_ElseGroup.Name = "label_ConditionsCreator_ElseGroup";
            this.label_ConditionsCreator_ElseGroup.Size = new System.Drawing.Size(83, 17);
            this.label_ConditionsCreator_ElseGroup.TabIndex = 8;
            this.label_ConditionsCreator_ElseGroup.Text = "Else Group:";
            // 
            // textBox_ConditionsCreator_SourceId
            // 
            this.textBox_ConditionsCreator_SourceId.Enabled = false;
            this.textBox_ConditionsCreator_SourceId.Location = new System.Drawing.Point(142, 85);
            this.textBox_ConditionsCreator_SourceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_SourceId.MaxLength = 1;
            this.textBox_ConditionsCreator_SourceId.Name = "textBox_ConditionsCreator_SourceId";
            this.textBox_ConditionsCreator_SourceId.Size = new System.Drawing.Size(27, 22);
            this.textBox_ConditionsCreator_SourceId.TabIndex = 7;
            this.textBox_ConditionsCreator_SourceId.Text = "0";
            this.textBox_ConditionsCreator_SourceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ConditionsCreator_SourceId
            // 
            this.label_ConditionsCreator_SourceId.AutoSize = true;
            this.label_ConditionsCreator_SourceId.Location = new System.Drawing.Point(7, 87);
            this.label_ConditionsCreator_SourceId.Name = "label_ConditionsCreator_SourceId";
            this.label_ConditionsCreator_SourceId.Size = new System.Drawing.Size(72, 17);
            this.label_ConditionsCreator_SourceId.TabIndex = 6;
            this.label_ConditionsCreator_SourceId.Text = "Source Id:";
            // 
            // textBox_ConditionsCreator_SourceEntry
            // 
            this.textBox_ConditionsCreator_SourceEntry.Enabled = false;
            this.textBox_ConditionsCreator_SourceEntry.Location = new System.Drawing.Point(142, 59);
            this.textBox_ConditionsCreator_SourceEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_SourceEntry.MaxLength = 6;
            this.textBox_ConditionsCreator_SourceEntry.Name = "textBox_ConditionsCreator_SourceEntry";
            this.textBox_ConditionsCreator_SourceEntry.Size = new System.Drawing.Size(89, 22);
            this.textBox_ConditionsCreator_SourceEntry.TabIndex = 5;
            // 
            // label_ConditionsCreator_SourceEntry
            // 
            this.label_ConditionsCreator_SourceEntry.AutoSize = true;
            this.label_ConditionsCreator_SourceEntry.Location = new System.Drawing.Point(7, 62);
            this.label_ConditionsCreator_SourceEntry.Name = "label_ConditionsCreator_SourceEntry";
            this.label_ConditionsCreator_SourceEntry.Size = new System.Drawing.Size(94, 17);
            this.label_ConditionsCreator_SourceEntry.TabIndex = 4;
            this.label_ConditionsCreator_SourceEntry.Text = "Source Entry:";
            // 
            // textBox_ConditionsCreator_SourceGroup
            // 
            this.textBox_ConditionsCreator_SourceGroup.Enabled = false;
            this.textBox_ConditionsCreator_SourceGroup.Location = new System.Drawing.Point(142, 34);
            this.textBox_ConditionsCreator_SourceGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ConditionsCreator_SourceGroup.MaxLength = 6;
            this.textBox_ConditionsCreator_SourceGroup.Name = "textBox_ConditionsCreator_SourceGroup";
            this.textBox_ConditionsCreator_SourceGroup.Size = new System.Drawing.Size(89, 22);
            this.textBox_ConditionsCreator_SourceGroup.TabIndex = 3;
            // 
            // label_ConditionsCreator_ConditionSourceGroup
            // 
            this.label_ConditionsCreator_ConditionSourceGroup.AutoSize = true;
            this.label_ConditionsCreator_ConditionSourceGroup.Location = new System.Drawing.Point(7, 36);
            this.label_ConditionsCreator_ConditionSourceGroup.Name = "label_ConditionsCreator_ConditionSourceGroup";
            this.label_ConditionsCreator_ConditionSourceGroup.Size = new System.Drawing.Size(101, 17);
            this.label_ConditionsCreator_ConditionSourceGroup.TabIndex = 2;
            this.label_ConditionsCreator_ConditionSourceGroup.Text = "Source Group:";
            // 
            // comboBox_ConditionsCreator_ConditionSourceType
            // 
            this.comboBox_ConditionsCreator_ConditionSourceType.FormattingEnabled = true;
            this.comboBox_ConditionsCreator_ConditionSourceType.Location = new System.Drawing.Point(142, 5);
            this.comboBox_ConditionsCreator_ConditionSourceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ConditionsCreator_ConditionSourceType.Name = "comboBox_ConditionsCreator_ConditionSourceType";
            this.comboBox_ConditionsCreator_ConditionSourceType.Size = new System.Drawing.Size(285, 24);
            this.comboBox_ConditionsCreator_ConditionSourceType.TabIndex = 1;
            this.comboBox_ConditionsCreator_ConditionSourceType.DropDown += new System.EventHandler(this.comboBox_ConditionSourceType_DropDown);
            this.comboBox_ConditionsCreator_ConditionSourceType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ConditionSourceType_SelectedIndexChanged);
            // 
            // label_ConditionsCreator_ConditionSourceType
            // 
            this.label_ConditionsCreator_ConditionSourceType.AutoSize = true;
            this.label_ConditionsCreator_ConditionSourceType.Location = new System.Drawing.Point(7, 7);
            this.label_ConditionsCreator_ConditionSourceType.Name = "label_ConditionsCreator_ConditionSourceType";
            this.label_ConditionsCreator_ConditionSourceType.Size = new System.Drawing.Size(93, 17);
            this.label_ConditionsCreator_ConditionSourceType.TabIndex = 0;
            this.label_ConditionsCreator_ConditionSourceType.Text = "Source Type:";
            // 
            // tabPage_ModifierTrees
            // 
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_TertiaryAsset);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_SecondaryAsset);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_Asset);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_Amount);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_Operator);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_Type);
            this.tabPage_ModifierTrees.Controls.Add(this.textBox_ModifierTrees_ModifierTreeId);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_ModifierTreeId);
            this.tabPage_ModifierTrees.Controls.Add(this.label_ModifierTrees_ModifierTrees);
            this.tabPage_ModifierTrees.Controls.Add(this.treeView_ModifierTrees_ModifierTrees);
            this.tabPage_ModifierTrees.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ModifierTrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_ModifierTrees.Name = "tabPage_ModifierTrees";
            this.tabPage_ModifierTrees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_ModifierTrees.Size = new System.Drawing.Size(1812, 761);
            this.tabPage_ModifierTrees.TabIndex = 8;
            this.tabPage_ModifierTrees.Text = "Modifier Trees";
            this.tabPage_ModifierTrees.UseVisualStyleBackColor = true;
            // 
            // label_ModifierTrees_TertiaryAsset
            // 
            this.label_ModifierTrees_TertiaryAsset.AutoSize = true;
            this.label_ModifierTrees_TertiaryAsset.Location = new System.Drawing.Point(5, 114);
            this.label_ModifierTrees_TertiaryAsset.Name = "label_ModifierTrees_TertiaryAsset";
            this.label_ModifierTrees_TertiaryAsset.Size = new System.Drawing.Size(100, 17);
            this.label_ModifierTrees_TertiaryAsset.TabIndex = 25;
            this.label_ModifierTrees_TertiaryAsset.Text = "Tertiary Asset:";
            // 
            // label_ModifierTrees_SecondaryAsset
            // 
            this.label_ModifierTrees_SecondaryAsset.AutoSize = true;
            this.label_ModifierTrees_SecondaryAsset.Location = new System.Drawing.Point(5, 98);
            this.label_ModifierTrees_SecondaryAsset.Name = "label_ModifierTrees_SecondaryAsset";
            this.label_ModifierTrees_SecondaryAsset.Size = new System.Drawing.Size(119, 17);
            this.label_ModifierTrees_SecondaryAsset.TabIndex = 24;
            this.label_ModifierTrees_SecondaryAsset.Text = "Secondary Asset:";
            // 
            // label_ModifierTrees_Asset
            // 
            this.label_ModifierTrees_Asset.AutoSize = true;
            this.label_ModifierTrees_Asset.Location = new System.Drawing.Point(5, 82);
            this.label_ModifierTrees_Asset.Name = "label_ModifierTrees_Asset";
            this.label_ModifierTrees_Asset.Size = new System.Drawing.Size(47, 17);
            this.label_ModifierTrees_Asset.TabIndex = 23;
            this.label_ModifierTrees_Asset.Text = "Asset:";
            // 
            // label_ModifierTrees_Amount
            // 
            this.label_ModifierTrees_Amount.AutoSize = true;
            this.label_ModifierTrees_Amount.Location = new System.Drawing.Point(5, 50);
            this.label_ModifierTrees_Amount.Name = "label_ModifierTrees_Amount";
            this.label_ModifierTrees_Amount.Size = new System.Drawing.Size(60, 17);
            this.label_ModifierTrees_Amount.TabIndex = 22;
            this.label_ModifierTrees_Amount.Text = "Amount:";
            // 
            // label_ModifierTrees_Operator
            // 
            this.label_ModifierTrees_Operator.AutoSize = true;
            this.label_ModifierTrees_Operator.Location = new System.Drawing.Point(5, 66);
            this.label_ModifierTrees_Operator.Name = "label_ModifierTrees_Operator";
            this.label_ModifierTrees_Operator.Size = new System.Drawing.Size(69, 17);
            this.label_ModifierTrees_Operator.TabIndex = 21;
            this.label_ModifierTrees_Operator.Text = "Operator:";
            // 
            // label_ModifierTrees_Type
            // 
            this.label_ModifierTrees_Type.AutoSize = true;
            this.label_ModifierTrees_Type.Location = new System.Drawing.Point(5, 34);
            this.label_ModifierTrees_Type.Name = "label_ModifierTrees_Type";
            this.label_ModifierTrees_Type.Size = new System.Drawing.Size(44, 17);
            this.label_ModifierTrees_Type.TabIndex = 20;
            this.label_ModifierTrees_Type.Text = "Type:";
            // 
            // textBox_ModifierTrees_ModifierTreeId
            // 
            this.textBox_ModifierTrees_ModifierTreeId.Location = new System.Drawing.Point(120, 8);
            this.textBox_ModifierTrees_ModifierTreeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ModifierTrees_ModifierTreeId.Name = "textBox_ModifierTrees_ModifierTreeId";
            this.textBox_ModifierTrees_ModifierTreeId.Size = new System.Drawing.Size(89, 22);
            this.textBox_ModifierTrees_ModifierTreeId.TabIndex = 19;
            this.textBox_ModifierTrees_ModifierTreeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ModifierTrees_ModifierTreeId_KeyUp);
            // 
            // label_ModifierTrees_ModifierTreeId
            // 
            this.label_ModifierTrees_ModifierTreeId.AutoSize = true;
            this.label_ModifierTrees_ModifierTreeId.Location = new System.Drawing.Point(5, 10);
            this.label_ModifierTrees_ModifierTreeId.Name = "label_ModifierTrees_ModifierTreeId";
            this.label_ModifierTrees_ModifierTreeId.Size = new System.Drawing.Size(111, 17);
            this.label_ModifierTrees_ModifierTreeId.TabIndex = 18;
            this.label_ModifierTrees_ModifierTreeId.Text = "Modifier Tree Id:";
            // 
            // label_ModifierTrees_ModifierTrees
            // 
            this.label_ModifierTrees_ModifierTrees.AutoSize = true;
            this.label_ModifierTrees_ModifierTrees.Location = new System.Drawing.Point(851, 106);
            this.label_ModifierTrees_ModifierTrees.Name = "label_ModifierTrees_ModifierTrees";
            this.label_ModifierTrees_ModifierTrees.Size = new System.Drawing.Size(0, 17);
            this.label_ModifierTrees_ModifierTrees.TabIndex = 15;
            // 
            // treeView_ModifierTrees_ModifierTrees
            // 
            this.treeView_ModifierTrees_ModifierTrees.Location = new System.Drawing.Point(3, 132);
            this.treeView_ModifierTrees_ModifierTrees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView_ModifierTrees_ModifierTrees.Name = "treeView_ModifierTrees_ModifierTrees";
            this.treeView_ModifierTrees_ModifierTrees.Size = new System.Drawing.Size(1803, 614);
            this.treeView_ModifierTrees_ModifierTrees.TabIndex = 14;
            // 
            // statusStrip_LoadedFile
            // 
            this.statusStrip_LoadedFile.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip_LoadedFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_LoadedFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_FileStatus,
            this.toolStripStatusLabel_CurrentAction});
            this.statusStrip_LoadedFile.Location = new System.Drawing.Point(0, 781);
            this.statusStrip_LoadedFile.Name = "statusStrip_LoadedFile";
            this.statusStrip_LoadedFile.Padding = new System.Windows.Forms.Padding(2, 0, 12, 0);
            this.statusStrip_LoadedFile.Size = new System.Drawing.Size(1832, 26);
            this.statusStrip_LoadedFile.TabIndex = 2;
            this.statusStrip_LoadedFile.Text = "statusStrip";
            // 
            // toolStripStatusLabel_FileStatus
            // 
            this.toolStripStatusLabel_FileStatus.Name = "toolStripStatusLabel_FileStatus";
            this.toolStripStatusLabel_FileStatus.Size = new System.Drawing.Size(110, 20);
            this.toolStripStatusLabel_FileStatus.Text = "No File Loaded";
            // 
            // toolStripStatusLabel_CurrentAction
            // 
            this.toolStripStatusLabel_CurrentAction.Name = "toolStripStatusLabel_CurrentAction";
            this.toolStripStatusLabel_CurrentAction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel_CurrentAction.Size = new System.Drawing.Size(0, 20);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Core_script_creatore_preview
            // 
            this.Core_script_creatore_preview.Location = new System.Drawing.Point(444, 39);
            this.Core_script_creatore_preview.Name = "Core_script_creatore_preview";
            this.Core_script_creatore_preview.ReadOnly = true;
            this.Core_script_creatore_preview.Size = new System.Drawing.Size(1362, 712);
            this.Core_script_creatore_preview.TabIndex = 7;
            this.Core_script_creatore_preview.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 807);
            this.Controls.Add(this.statusStrip_LoadedFile);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Wow Developer Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage_CreatureScriptsCreator.ResumeLayout(false);
            this.tabPage_CreatureScriptsCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CreatureScriptsCreator_Spells)).EndInit();
            this.contextMenuStrip_CreatureScriptsCreator.ResumeLayout(false);
            this.toolStrip_CreatureScriptsCreator.ResumeLayout(false);
            this.toolStrip_CreatureScriptsCreator.PerformLayout();
            this.tabPage_WaypointsCreator.ResumeLayout(false);
            this.tabPage_WaypointsCreator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_WaypointsCreator_Waypoints)).EndInit();
            this.contextMenuStrip_WaypointsCreator.ResumeLayout(false);
            this.contextMenuStrip_WaypointsCreator_Guids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_WaypointsCreator_Path)).EndInit();
            this.toolStrip_WaypointsCreator.ResumeLayout(false);
            this.toolStrip_WaypointsCreator.PerformLayout();
            this.tabPage_SqlOutput.ResumeLayout(false);
            this.tabPage_SqlOutput.PerformLayout();
            this.tabPage_DatabaseAdvisor.ResumeLayout(false);
            this.tabPage_DatabaseAdvisor.PerformLayout();
            this.contextMenuStrip_DatabaseAdvisor.ResumeLayout(false);
            this.tabPage_DoubleSpawnsRemover.ResumeLayout(false);
            this.tabPage_DoubleSpawnsRemover.PerformLayout();
            this.tabPage_CoreScriptTemplates.ResumeLayout(false);
            this.tabPage_CoreScriptTemplates.PerformLayout();
            this.tabPage_Achievements.ResumeLayout(false);
            this.tabPage_Achievements.PerformLayout();
            this.tabPage_ConditionsCreator.ResumeLayout(false);
            this.tabPage_ConditionsCreator.PerformLayout();
            this.tabPage_ModifierTrees.ResumeLayout(false);
            this.tabPage_ModifierTrees.PerformLayout();
            this.statusStrip_LoadedFile.ResumeLayout(false);
            this.statusStrip_LoadedFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_CreatureScriptsCreator;
        private System.Windows.Forms.ToolStrip toolStrip_CreatureScriptsCreator;
        public System.Windows.Forms.ToolStripButton toolStripButton_CSC_ImportSniff;
        public System.Windows.Forms.ToolStripButton toolStripButton_CreatureScriptsCreator_Search;
        private System.Windows.Forms.TabPage tabPage_SqlOutput;
        private System.Windows.Forms.StatusStrip statusStrip_LoadedFile;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_FileStatus;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox_CreatureScriptsCreator_CreatureEntry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_CreatureScriptsCreator_CreatureEntry;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.DataGridView dataGridView_CreatureScriptsCreator_Spells;
        public System.Windows.Forms.ListBox listBox_CreatureScriptCreator_CreatureGuids;
        public System.Windows.Forms.CheckBox checkBox_CreatureScriptsCreator_OnlyCombatSpells;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_CreatureScriptsCreator;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem createSmartAISqlToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox_SqlOutput;
        private System.Windows.Forms.TabPage tabPage_DatabaseAdvisor;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_CreatureFlags;
        private System.Windows.Forms.Label label_DatabaseAdvisor_CreatureFlags;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_QuestFlags;
        private System.Windows.Forms.Label label_DatabaseAdvisor_QuestFlags;
        private System.Windows.Forms.TabPage tabPage_DoubleSpawnsRemover;
        private System.Windows.Forms.Label label_DoubleSpawnsRemover_CreaturesRemoved;
        private System.Windows.Forms.Button button_DoubleSpawnsRemover_ImportFile;
        private System.Windows.Forms.CheckBox checkBox_DoubleSpawnsRemover_Gameobjects;
        private System.Windows.Forms.CheckBox checkBox_DoubleSpawnsRemover_Creatures;
        private System.Windows.Forms.Label label_DoubleSpawnsRemover_GameobjectsRemoved;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCastStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCastStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCastRepeatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCastRepeatTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceSpell;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_AreatriggerSplines;
        private System.Windows.Forms.Label label_DatabaseAdvisor_AreatriggerSplines;
        private System.Windows.Forms.TabPage tabPage_WaypointsCreator;
        internal System.Windows.Forms.DataGridView grid_WaypointsCreator_Waypoints;
        public System.Windows.Forms.ListBox listBox_WaypointsCreator_CreatureGuids;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart_WaypointsCreator_Path;
        private System.Windows.Forms.ToolStrip toolStrip_WaypointsCreator;
        public System.Windows.Forms.ToolStripButton toolStripButton_WaypointsCreator_Search;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox_WaypointsCreator_Entry;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_WaypointsCreator_Entry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_WaypointsCreator_Settings;
        public System.Windows.Forms.ToolStripButton toolStripButton_WaypointsCreator_LoadSniff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_WaypointsCreator;
        private System.Windows.Forms.ToolStripMenuItem createSQLToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripMenuItem removeNearestPointsToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_PosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_PosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_PosZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_Orientation;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_WCTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_WCDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_HasScript;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaypointSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_CSC;
        private System.Windows.Forms.ToolStripMenuItem removeDuplicatePointsToolStripMenuItem_WC;
        private System.Windows.Forms.ToolStripMenuItem createReturnPathToolStripMenuItem_WC;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CurrentAction;
        private System.Windows.Forms.TabPage tabPage_CoreScriptTemplates;
        public System.Windows.Forms.ListBox listBox_CoreScriptTemplates_Hooks;
        public System.Windows.Forms.ComboBox comboBox_CoreScriptTemplates_ScriptType;
        public System.Windows.Forms.TextBox textBox_CoreScriptTemplates_ObjectId;
        private System.Windows.Forms.Label label_CoreScriptTemplates_ScriptType;
        private System.Windows.Forms.Label label_CoreScriptTemplates_ObjectId;
        public System.Windows.Forms.TreeView treeView_CoreScriptTemplates_HookBodies;
        public System.Windows.Forms.TabPage tabPage_Achievements;
        public System.Windows.Forms.TextBox textBox_Achievements_AchievementId;
        public System.Windows.Forms.Label label_Achievements_AchievementId;
        public System.Windows.Forms.TreeView treeView_Achievements_ChildNodes;
        public System.Windows.Forms.Label label_Achievements_AchievementName;
        public System.Windows.Forms.Label label_Achievements_CriteriaTreeChildNodes;
        public System.Windows.Forms.Label label_Achievement_CriteriaTreeOperator;
        public System.Windows.Forms.Label label_Achievements_CriteriaTreeName;
        public System.Windows.Forms.Label label_Achievements_CriteriaTreeId;
        public System.Windows.Forms.Label label_Achievements_AchievementFlags;
        public System.Windows.Forms.Label label_Achievements_AchievementFaction;
        public System.Windows.Forms.Label label_Achievements_CriteriaTreeAmount;
        public System.Windows.Forms.TreeView treeView_Achievements_Criterias;
        private System.Windows.Forms.Label label_Achievements_Criterias;
        private System.Windows.Forms.Label label_Achievements_ModifierTrees;
        public System.Windows.Forms.TreeView treeView_Achievements_ModifierTrees;
        private System.Windows.Forms.Label label_Achievements_ModifierTreeChildNodes;
        public System.Windows.Forms.TreeView treeView_Achievements_ModifierTreeChildNodes;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_SpellDestinations;
        private System.Windows.Forms.Label label_DatabaseAdvisor_SpellDestinations;
        private System.Windows.Forms.TabPage tabPage_ConditionsCreator;
        public System.Windows.Forms.ComboBox comboBox_ConditionsCreator_ConditionSourceType;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionSourceType;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionType;
        public System.Windows.Forms.ComboBox comboBox_ConditionsCreator_ConditionType;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_ElseGroup;
        private System.Windows.Forms.Label label_ConditionsCreator_ElseGroup;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_SourceId;
        private System.Windows.Forms.Label label_ConditionsCreator_SourceId;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_SourceEntry;
        private System.Windows.Forms.Label label_ConditionsCreator_SourceEntry;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_SourceGroup;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionSourceGroup;
        private System.Windows.Forms.Label label_ConditionsCreator_ScriptName;
        private System.Windows.Forms.Label label_ConditionsCreator_NegativeCondition;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionValue3;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionValue2;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionValue1;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_ScriptName;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_NegativeCondition;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_ConditionValue3;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_ConditionValue2;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_ConditionValue1;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_ConditionTarget;
        private System.Windows.Forms.Label label_ConditionsCreator_ConditionTarget;
        public System.Windows.Forms.TextBox textBox_ConditionsCreator_Output;
        private System.Windows.Forms.Button button_ConditionsCreator_AddCondition;
        private System.Windows.Forms.Button button_ConditionsCreator_ClearConditions;
        public System.Windows.Forms.TextBox textBox_DatabaseAdvisor_Output;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_GossipMenuText;
        private System.Windows.Forms.Label label_DatabaseAdvisor_GossipMenuText;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_PlayerCastedSpells;
        private System.Windows.Forms.Label label_DatabaseAdvisor_PlayerCasterSpells;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_WaypointsCreator_Guids;
        private System.Windows.Forms.ToolStripMenuItem removeGuidsBeforeSelectedToolStripMenuItem;
        public System.Windows.Forms.CheckBox checkBox_CreatureScriptsCreator_CreateDataFile;
        public System.Windows.Forms.CheckBox checkBox_WaypointsCreator_CreateDataFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_DatabaseAdvisor;
        private System.Windows.Forms.ToolStripMenuItem createReturnPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalculatePointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRandomMovementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInhabitTypeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_DatabaseAdvisor_FindDoublePaths;
        private System.Windows.Forms.Label label_DatabaseAdvisor_FindDoublePaths;
        private System.Windows.Forms.ToolStripMenuItem getAddonsFromSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCoreScriptToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_ModifierTrees;
        public System.Windows.Forms.TextBox textBox_ModifierTrees_ModifierTreeId;
        public System.Windows.Forms.Label label_ModifierTrees_ModifierTreeId;
        private System.Windows.Forms.Label label_ModifierTrees_ModifierTrees;
        public System.Windows.Forms.TreeView treeView_ModifierTrees_ModifierTrees;
        public System.Windows.Forms.Label label_ModifierTrees_Operator;
        public System.Windows.Forms.Label label_ModifierTrees_Type;
        public System.Windows.Forms.Label label_ModifierTrees_Amount;
        public System.Windows.Forms.Label label_ModifierTrees_TertiaryAsset;
        public System.Windows.Forms.Label label_ModifierTrees_SecondaryAsset;
        public System.Windows.Forms.Label label_ModifierTrees_Asset;
        private System.Windows.Forms.ToolStripMenuItem createLegionCombatAISqlToolStripMenuItem;
        public System.Windows.Forms.RichTextBox Core_script_creatore_preview;
    }
}

