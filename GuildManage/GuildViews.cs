using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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

        private void dataHeroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GuildeManageEntities entities = new GuildeManageEntities();
            entities.SaveChanges();
        }

        private void refersheData()
        {
            dataHeroGrid.DataSource = null;
            GuildeManageEntities entite = new GuildeManageEntities();
            List<Héros> listArticles = entite.Héros.ToList();
            dataHeroGrid.DataSource = listArticles;
        }

        private void viderLesChamps()
        {
            NomBox.Text = "";
            PrénomBox.Text = "";
            SpéBox.Text = "";
            ClasseBox.Text = "";
            NiveauBox.Value = 0;
            PuissanceBox.Value = 0;
            RéussiteBox.Value = 0;
            RéputBox.Text = "";
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataHeroGrid.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0){

                GuildeManageEntities entite = new GuildeManageEntities();
                int idHéro = int.Parse(dataHeroGrid.SelectedRows[0].Cells[8].Value.ToString());
                Console.WriteLine(idHéro);

                Héros HeroUpdate = entite.Héros.Where(a => a.Héro_id == idHéro).FirstOrDefault();

                HeroUpdate.Nom = NomBox.Text;
                HeroUpdate.Prénom = PrénomBox.Text;
                HeroUpdate.Spécialité = SpéBox.Text;
                HeroUpdate.Classe_héro = ClasseBox.Text;
                HeroUpdate.Niveau = (int)NiveauBox.Value;
                HeroUpdate.Puissance = (int)PuissanceBox.Value;
                HeroUpdate.Réussite = (int)RéussiteBox.Value;
                HeroUpdate.Réputation = RéputBox.Text;

                entite.Héros.AddOrUpdate(HeroUpdate);

                entite.SaveChanges();
                refersheData();
                viderLesChamps();
            }
        }

        private void dataHeroGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataHeroGrid.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                NomBox.Text = dataHeroGrid.SelectedRows[0].Cells[0].Value.ToString();
                PrénomBox.Text = dataHeroGrid.SelectedRows[0].Cells[1].Value.ToString();
                SpéBox.Text = dataHeroGrid.SelectedRows[0].Cells[2].Value.ToString();
                ClasseBox.Text = dataHeroGrid.SelectedRows[0].Cells[3].Value.ToString();
                NiveauBox.Value = decimal.Parse(dataHeroGrid.SelectedRows[0].Cells[4].Value.ToString());
                PuissanceBox.Value = decimal.Parse(dataHeroGrid.SelectedRows[0].Cells[5].Value.ToString());
                RéussiteBox.Value = decimal.Parse(dataHeroGrid.SelectedRows[0].Cells[6].Value.ToString());
                RéputBox.Text = dataHeroGrid.SelectedRows[0].Cells[7].Value.ToString();

            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (dataHeroGrid.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {

                GuildeManageEntities entite = new GuildeManageEntities();
                int idHéro = int.Parse(dataHeroGrid.SelectedRows[0].Cells[8].Value.ToString());
                Console.WriteLine(idHéro);


                Héros hérosADelete = entite.Héros.Where(a => a.Héro_id == idHéro).FirstOrDefault();
                entite.Héros.Remove(hérosADelete);
                entite.SaveChanges();
                refersheData();
                viderLesChamps();
            }
        }

        private void AjouterHero_Click(object sender, EventArgs e)
        {
            Héros NewHero = new Héros();
            NewHero.Nom = NomBox.Text;
            NewHero.Prénom = PrénomBox.Text;
            NewHero.Spécialité = SpéBox.Text;
            NewHero.Classe_héro = ClasseBox.Text;
            NewHero.Niveau = (int)NiveauBox.Value;
            NewHero.Puissance = (int)PuissanceBox.Value;
            NewHero.Réussite = (int)RéussiteBox.Value;
            NewHero.Réputation = RéputBox.Text;

            GuildeManageEntities entite = new GuildeManageEntities();
            entite.Héros.Add(NewHero);
            entite.SaveChanges();

            this.refersheData();

            viderLesChamps();
        }
    }
}
