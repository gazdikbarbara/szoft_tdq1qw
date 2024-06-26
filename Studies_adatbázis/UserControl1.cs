﻿using Studies_adatbázis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies_adatbázis
{
    public partial class UserControl1 : UserControl
    {
        Models.StudiesContext context = new Models.StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Instructors
                        select i;
            listBox1.DataSource = ilist.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor instructor = (Instructor)listBox1.SelectedItem;

            var lessons = from l in context.Lessons
                          where l.InstructorFk == instructor.InstructorSk
                          select new
                          {
                              Kurzus = l.CourseFkNavigation.Name,
                              Nap = l.DayFkNavigation.Name,
                              Sáv = l.TimeFkNavigation.Name,
                          };

            dataGridView1.DataSource = lessons.ToList();
        }
    }
}
