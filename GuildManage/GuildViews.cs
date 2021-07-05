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
            GuildeManageEntities3 entities = new GuildeManageEntities3();
            List<Héros> listHéros = entities.Héros.ToList();
            dataHeroGrid.DataSource = listHéros;


        }

        private void dataHeroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GuildeManageEntities3 entities = new GuildeManageEntities3();
            entities.SaveChanges();
        }

        private void refersheData()
        {
            dataHeroGrid.DataSource = null;
            GuildeManageEntities3 entite = new GuildeManageEntities3();
            List<Héros> listArticles = entite.Héros.ToList();
            dataHeroGrid.DataSource = listArticles;
        }

        private void refersheDataObjet()
        {
            dataGridSaccoche.DataSource = null;
            GuildeManageEntities3 entite = new GuildeManageEntities3();
            int idHéro = (int)HeroID.Value;
            List<Objets> listSac = new List<Objets>();
            List<HerObjet> listHerObject = entite.HerObjet.ToList();
            for (int i = 0; i < listHerObject.Count; i++)
            {
                if (listHerObject[i].HeroID == idHéro)
                {
                    int IdItem = listHerObject[i].ObjetID;
                    Objets ItemSelected = entite.Objets.Where(a => a.Objet_id == IdItem).FirstOrDefault();
                    ItemSelected.Quantité = listHerObject[i].Quantité;
                    listSac.Add(ItemSelected);
                }
            }
            dataGridSaccoche.DataSource = listSac;
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
            HeroID.Value = 0;
        }

        private void viderLesChampsObjets()
        {
            NomObjetBox.Text = "";
            LvlObjetBox.Value = 0;
            PrixObjetBox.Value = 0;
            QuantiteObjetBox.Value = 0;
            DesObjetBox.Text = "";
        }


        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataHeroGrid.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0){

                GuildeManageEntities3 entite = new GuildeManageEntities3();
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
                HeroID.Value = decimal.Parse(dataHeroGrid.SelectedRows[0].Cells[8].Value.ToString());
                refersheDataObjet();
                viderLesChampsObjets();

            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (dataHeroGrid.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {

                GuildeManageEntities3 entite = new GuildeManageEntities3();
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

            GuildeManageEntities3 entite = new GuildeManageEntities3();
            entite.Héros.Add(NewHero);
            entite.SaveChanges();

            this.refersheData();

            viderLesChamps();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (HeroID.Value != 0)
            {
                GuildeManageEntities3 entite = new GuildeManageEntities3();

                int idHéro = (int)HeroID.Value;
                List<Objets> listSac = new List<Objets>();
                List<HerObjet> listHerObject = entite.HerObjet.ToList();
                for (int i = 0; i < listHerObject.Count; i++)
                {
                    if (listHerObject[i].HeroID == idHéro)
                    {
                        int IdItem = listHerObject[i].ObjetID;
                        Objets ItemSelected = entite.Objets.Where(a => a.Objet_id == IdItem).FirstOrDefault();
                        ItemSelected.Quantité = listHerObject[i].Quantité;
                        listSac.Add(ItemSelected);
                    }
                }
                dataGridSaccoche.DataSource = listSac;
            }
        }

        private void AjoutObjet_Click(object sender, EventArgs e)
        {
           
            GuildeManageEntities3 entite = new GuildeManageEntities3();

                Objets NewObjet = new Objets();
                NewObjet.Nom = NomObjetBox.Text;
                NewObjet.Ilvl = (int)LvlObjetBox.Value;
                NewObjet.Prix = (int)PrixObjetBox.Value;
                NewObjet.Quantité = (int)QuantiteObjetBox.Value;
                NewObjet.Description = DesObjetBox.Text;


                entite.Objets.Add(NewObjet);
                entite.SaveChanges();
                
                List<Objets> listHerObject = entite.Objets.ToList();
                int LastRow = listHerObject.Count - 1;
                int LastObjetID = listHerObject[LastRow].Objet_id;

                HerObjet NewHerObjet = new HerObjet();
                NewHerObjet.HeroID = (int)HeroID.Value;
                NewHerObjet.ObjetID = LastObjetID;
                NewHerObjet.Quantité = (int)QuantiteObjetBox.Value;

                entite.HerObjet.Add(NewHerObjet);
                entite.SaveChanges();

                refersheDataObjet();
                viderLesChampsObjets();
        }

        private void ModifierObjet_Click(object sender, EventArgs e)
        {
            if (dataGridSaccoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {

                GuildeManageEntities3 entite = new GuildeManageEntities3();
                int idObjet = int.Parse(dataGridSaccoche.SelectedRows[0].Cells[4].Value.ToString());
                Objets ObjetUpdate = entite.Objets.Where(a => a.Objet_id == idObjet).FirstOrDefault();

                ObjetUpdate.Nom = NomObjetBox.Text;
                ObjetUpdate.Ilvl = (int)LvlObjetBox.Value;
                ObjetUpdate.Prix = (int)PrixObjetBox.Value;
                ObjetUpdate.Quantité = (int)QuantiteObjetBox.Value;
                ObjetUpdate.Description = DesObjetBox.Text;

                entite.Objets.AddOrUpdate(ObjetUpdate);

                int idHéro = (int)HeroID.Value;

                HerObjet HerObjetUpdate = entite.HerObjet.Where(a => a.ObjetID == idObjet && a.HeroID == idHéro).FirstOrDefault();
                HerObjetUpdate.HeroID = (int)HeroID.Value;
                HerObjetUpdate.ObjetID = idObjet;
                HerObjetUpdate.Quantité = (int)QuantiteObjetBox.Value;
                entite.HerObjet.AddOrUpdate(HerObjetUpdate);

                entite.SaveChanges();
                refersheDataObjet();
                viderLesChampsObjets();

            }
        }
        

        private void SupprimerObjet_Click(object sender, EventArgs e)
        {
            if (dataGridSaccoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {

                GuildeManageEntities3 entite = new GuildeManageEntities3();
                int idHéro = (int)HeroID.Value;
                int idObjet = (int)ObjetID.Value;

                HerObjet HerObjetDelete = entite.HerObjet.Where(a => a.ObjetID == idObjet && a.HeroID == idHéro).FirstOrDefault();
                entite.HerObjet.Remove(HerObjetDelete);
                entite.SaveChanges();
                refersheDataObjet();
                viderLesChampsObjets();
            }
        }


        private void dataGridSaccoche_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridSaccoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                NomObjetBox.Text = dataGridSaccoche.SelectedRows[0].Cells[0].Value.ToString();
                DesObjetBox.Text = dataGridSaccoche.SelectedRows[0].Cells[2].Value.ToString();
                LvlObjetBox.Value = decimal.Parse(dataGridSaccoche.SelectedRows[0].Cells[1].Value.ToString());
                PrixObjetBox.Value = decimal.Parse(dataGridSaccoche.SelectedRows[0].Cells[3].Value.ToString());
                QuantiteObjetBox.Value = decimal.Parse(dataGridSaccoche.SelectedRows[0].Cells[5].Value.ToString());
                ObjetID.Value = decimal.Parse(dataGridSaccoche.SelectedRows[0].Cells[4].Value.ToString());


            }
        }

        private void ObjetID_CursorChanged(object sender, EventArgs e)
        {
            ObjetID.Value = decimal.Parse(dataGridSaccoche.SelectedRows[0].Cells[4].Value.ToString());
        }
    }
}
