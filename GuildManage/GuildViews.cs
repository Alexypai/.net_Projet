using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuildManage
{
    public partial class GuildeView : Form
    {
        public GuildeView()
        {
            InitializeComponent();
        }

        private void GuildeView_Load(object sender, EventArgs e)
        {
            GuildeManageEntities entities = new GuildeManageEntities();
            List<Héros> listHéros = entities.Héros.ToList();
            dataHeroGrid.DataSource = listHéros;
        }
    }
}
