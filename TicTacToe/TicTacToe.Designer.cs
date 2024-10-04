using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLeft = new System.Windows.Forms.Button();
            this.topRight = new System.Windows.Forms.Button();
            this.topMid = new System.Windows.Forms.Button();
            this.bottomRight = new System.Windows.Forms.Button();
            this.bottomMid = new System.Windows.Forms.Button();
            this.bottomLeft = new System.Windows.Forms.Button();
            this.midRight = new System.Windows.Forms.Button();
            this.midMid = new System.Windows.Forms.Button();
            this.midLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.gameState = new System.Windows.Forms.Label();
            this.pOneWins = new System.Windows.Forms.Label();
            this.pTwoWins = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLeft
            // 
            this.topLeft.Enabled = false;
            this.topLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeft.Location = new System.Drawing.Point(3, 3);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(279, 178);
            this.topLeft.TabIndex = 0;
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.TopLeft_Click);
            // 
            // topRight
            // 
            this.topRight.Enabled = false;
            this.topRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRight.Location = new System.Drawing.Point(573, 3);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(281, 178);
            this.topRight.TabIndex = 2;
            this.topRight.UseVisualStyleBackColor = true;
            this.topRight.Click += new System.EventHandler(this.TopRight_Click);
            // 
            // topMid
            // 
            this.topMid.Enabled = false;
            this.topMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMid.Location = new System.Drawing.Point(288, 3);
            this.topMid.Name = "topMid";
            this.topMid.Size = new System.Drawing.Size(279, 178);
            this.topMid.TabIndex = 1;
            this.topMid.UseVisualStyleBackColor = true;
            this.topMid.Click += new System.EventHandler(this.TopMid_Click);
            // 
            // bottomRight
            // 
            this.bottomRight.Enabled = false;
            this.bottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRight.Location = new System.Drawing.Point(573, 372);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(281, 179);
            this.bottomRight.TabIndex = 8;
            this.bottomRight.UseVisualStyleBackColor = true;
            this.bottomRight.Click += new System.EventHandler(this.BottomRight_Click);
            // 
            // bottomMid
            // 
            this.bottomMid.Enabled = false;
            this.bottomMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMid.Location = new System.Drawing.Point(288, 372);
            this.bottomMid.Name = "bottomMid";
            this.bottomMid.Size = new System.Drawing.Size(279, 179);
            this.bottomMid.TabIndex = 7;
            this.bottomMid.UseVisualStyleBackColor = true;
            this.bottomMid.Click += new System.EventHandler(this.BottomMid_Click);
            // 
            // bottomLeft
            // 
            this.bottomLeft.Enabled = false;
            this.bottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeft.Location = new System.Drawing.Point(3, 372);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(279, 179);
            this.bottomLeft.TabIndex = 6;
            this.bottomLeft.UseVisualStyleBackColor = true;
            this.bottomLeft.Click += new System.EventHandler(this.BottomLeft_Click);
            // 
            // midRight
            // 
            this.midRight.Enabled = false;
            this.midRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midRight.Location = new System.Drawing.Point(573, 188);
            this.midRight.Name = "midRight";
            this.midRight.Size = new System.Drawing.Size(281, 178);
            this.midRight.TabIndex = 5;
            this.midRight.UseVisualStyleBackColor = true;
            this.midRight.Click += new System.EventHandler(this.MidRight_Click);
            // 
            // midMid
            // 
            this.midMid.Enabled = false;
            this.midMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midMid.Location = new System.Drawing.Point(288, 188);
            this.midMid.Name = "midMid";
            this.midMid.Size = new System.Drawing.Size(279, 178);
            this.midMid.TabIndex = 4;
            this.midMid.UseVisualStyleBackColor = true;
            this.midMid.Click += new System.EventHandler(this.MidMid_Click);
            // 
            // midLeft
            // 
            this.midLeft.Enabled = false;
            this.midLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midLeft.Location = new System.Drawing.Point(3, 188);
            this.midLeft.Name = "midLeft";
            this.midLeft.Size = new System.Drawing.Size(279, 178);
            this.midLeft.TabIndex = 3;
            this.midLeft.UseVisualStyleBackColor = true;
            this.midLeft.Click += new System.EventHandler(this.MidLeft_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33222F));
            this.tableLayoutPanel1.Controls.Add(this.midLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bottomLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bottomMid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bottomRight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.topRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.topLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.midMid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.midRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.topMid, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 555);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startButton.Location = new System.Drawing.Point(725, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(132, 48);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // gameState
            // 
            this.gameState.AutoSize = true;
            this.gameState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameState.Location = new System.Drawing.Point(233, 9);
            this.gameState.Name = "gameState";
            this.gameState.Size = new System.Drawing.Size(400, 36);
            this.gameState.TabIndex = 6;
            this.gameState.Text = "Are you read to Tic Tac Toe?";
            this.gameState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pOneWins
            // 
            this.pOneWins.AutoSize = true;
            this.pOneWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOneWins.Location = new System.Drawing.Point(0, 0);
            this.pOneWins.Name = "pOneWins";
            this.pOneWins.Size = new System.Drawing.Size(132, 25);
            this.pOneWins.TabIndex = 7;
            this.pOneWins.Text = "Player One: 0";
            // 
            // pTwoWins
            // 
            this.pTwoWins.AutoSize = true;
            this.pTwoWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTwoWins.Location = new System.Drawing.Point(0, 23);
            this.pTwoWins.Name = "pTwoWins";
            this.pTwoWins.Size = new System.Drawing.Size(132, 25);
            this.pTwoWins.TabIndex = 8;
            this.pTwoWins.Text = "Player Two: 0";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 603);
            this.Controls.Add(this.pTwoWins);
            this.Controls.Add(this.pOneWins);
            this.Controls.Add(this.gameState);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button topLeft;
        private Button topRight;
        private Button topMid;
        private Button bottomRight;
        private Button bottomMid;
        private Button bottomLeft;
        private Button midRight;
        private Button midMid;
        private Button midLeft;
        private TableLayoutPanel tableLayoutPanel1;
        private Button startButton;
        private Label gameState;
        private Label pOneWins;
        private Label pTwoWins;
    }
}

