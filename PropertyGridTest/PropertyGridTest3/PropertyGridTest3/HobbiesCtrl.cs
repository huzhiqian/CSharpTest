using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridTest3
{
    public partial class HobbiesCtrl : UserControl
    {
        public Hobbies m_new_hobbies;
        public Hobbies m_old_hobbies;
        private bool canceling = false;
        public HobbiesCtrl(Hobbies hobbies)
        {
            InitializeComponent();
            m_old_hobbies = hobbies;
            m_new_hobbies = hobbies;
        }


        public Hobbies Hobbies
        {
            get { return m_new_hobbies; }
        }

        private void HobbiesCtrl_Load(object sender, EventArgs e)
        {
            checkBox1.CheckState = m_old_hobbies.Music ? CheckState.Checked : CheckState.Unchecked;
            checkBox2.CheckState = m_old_hobbies.Game ? CheckState.Checked : CheckState.Unchecked;
            checkBox3.CheckState = m_old_hobbies.Running ? CheckState.Checked : CheckState.Unchecked;
            checkBox4.CheckState = m_old_hobbies.Film ? CheckState.Checked : CheckState.Unchecked;
            checkBox5.CheckState = m_old_hobbies.Basketball ? CheckState.Checked : CheckState.Unchecked;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                m_old_hobbies = m_new_hobbies;
                canceling = true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void HobbiesCtrl_Leave(object sender, EventArgs e)
        {
            if (!canceling)
            {
                if (checkBox1.Checked)
                    m_new_hobbies.Music = true;
                else
                    m_new_hobbies.Music = false;
                //
                if (checkBox2.Checked)
                    m_new_hobbies.Game = true;
                else
                    m_new_hobbies.Game = false;
                //
                if (checkBox3.Checked)
                    m_new_hobbies.Running = true;
                else
                    m_new_hobbies.Running = false;
                //
                if (checkBox4.Checked)
                    m_new_hobbies.Film = true;
                else
                    m_new_hobbies.Film = false;
                //
                if (checkBox5.Checked)
                    m_new_hobbies.Basketball = true;
                else
                    m_new_hobbies.Basketball = false;
            }
        }
    }
}
