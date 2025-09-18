/*
 *  Modificado por: Miguel Rodríguez Gallego
 *  Fecha: 25.dic.2021
 */

using Miguel_Rodríguez_01.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miguel_Rodríguez_01
{
    public partial class Ej01Form : Form
    {
        private List<ChPlayer> chPlayers = new List<ChPlayer>()
        {
            {   new ChPlayer(Resources.SwordCaptain02, Character.CharacterType.Sword, "Byleth",   50)   },
            {   new ChPlayer(Resources.AxeCaptain02, Character.CharacterType.Axe  , "Edelgard", 50)     },
            {   new ChPlayer(Resources.SpearSoldier02, Character.CharacterType.Spear, "Dimitri",  50)   }
        };

        private List<ChEnemy> chEnemies = new List<ChEnemy>()
        {
            {   new ChEnemy(Character.CharacterType.Sword, "Felix", 100)   },
            {   new ChEnemy(Character.CharacterType.Axe, "Caspar",  100)   },
            {   new ChEnemy(Character.CharacterType.Spear, "Hilda", 100)   }
        };

        // Música
        SoundPlayer music = new SoundPlayer(Resources.PokBattle);

        private bool[] enemAliv = new bool[] { true, true, true };

        private Random rnd = new Random();

        private int killCount = 0;

        private int timeCount = 0;

        public Ej01Form()
        {
            InitializeComponent();
        }

        private void Ej01Form_Load(object sender, EventArgs e)
        {
            cbPlayer.Items.Add(chPlayers[0].name);
            cbPlayer.Items.Add(chPlayers[1].name);
            cbPlayer.Items.Add(chPlayers[2].name);

            cbPlayer.SelectedIndex = 0;
            UpdateComboBox(cbPlayer.SelectedIndex);

            lblEnSwordName.Text = chEnemies[0].name;
            lblEnAxeName.Text   = chEnemies[1].name;
            lblEnSpearName.Text = chEnemies[2].name;

            music.PlayLooping();

            tmrCrono.Start();
            lblTimer.Text = timeCount.ToString();
        }

        private void cbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(cbPlayer.SelectedIndex);
        }

        private void UpdateComboBox(int index)
        {
            pbPlayer.Image = chPlayers[index].picture;
            lblPlayerName.Text = chPlayers[index].name;
            lblPlayerDamage.Text = chPlayers[index].GetDmg().ToString();
        }

        private void UpdateEneHP(int i)
        {
            if(enemAliv[i])
            {
                switch (i)
                {
                    case 0:
                        pgbEnSword.Value = chEnemies[i].health;
                        break;
                    case 1:
                        pgbEnAxe.Value   = chEnemies[i].health;
                        break;
                    case 2:
                        pgbEnSpear.Value = chEnemies[i].health;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 0:
                        pbEnSword.Image = Resources.Grave;
                        pgbEnSword.Value = 0;
                        break;
                    case 1:
                        pbEnAxe.Image = Resources.Grave;
                        pgbEnAxe.Value = 0;
                        break;
                    case 2:
                        pbEnSpear.Image = Resources.Grave;
                        pgbEnSpear.Value = 0;
                        break;
                    default:
                        break;
                }
            }
        }

        private void attackPlayer_Click(object sender, EventArgs e)
        {
            int selDef = rnd.Next(0, chEnemies.Count);

            while (!enemAliv[selDef])
            {
                selDef = rnd.Next(0, chEnemies.Count);
            }

            MakeAnAttack
            (
                chPlayers[cbPlayer.SelectedIndex],
                chEnemies[selDef]
            );

            if (chEnemies[selDef].health <= 0)
            {
                killCount++;
                enemAliv[selDef] = false;

                if (killCount == chEnemies.Count)
                {
                    btnAttack.Enabled = false;
                    UpdateEneHP(selDef);

                    DialogResult result = MessageBox.Show
                    (
                        "Restart game", "You win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if(result == DialogResult.Yes)
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

            UpdateEneHP(selDef);
        }

        private static void MakeAnAttack(IAttacker attacker, IDefender defender)
        {
            defender.ReceiveDmg(attacker.GetDmg(), attacker.GetDmgType());
        }

        // Timer
        private void tmrCrono_Tick(object sender, EventArgs e)
        {
            timeCount++;
            lblTimer.Text = timeCount.ToString();
        }
    }
}
