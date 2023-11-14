using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {

  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private bool Blocking = false;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health, stamina, mana
      UpdateHealthBars();
      UpdateStaminaBars();
      UpdateManaBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void UpdateStaminaBars() {
       float playerStaminaPer = player.Stamina / (float)player.MaxStamina;

       const int MAX_STAMINABAR_WIDTH = 226;
       lblPlayerStaminaFull.Width = (int)(MAX_STAMINABAR_WIDTH * playerStaminaPer);

       lblPlayerStaminaFull.Text = player.Stamina.ToString();
        }

    private void UpdateManaBars() {
       float playerManaPer = player.Mana / (float)player.MaxMana;

       const int MAX_MANABAR_WIDTH = 226;
       lblPlayerManaFull.Width = (int)(MAX_MANABAR_WIDTH * playerManaPer);

       lblPlayerManaFull.Text = player.Mana.ToString();
        }

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
                Game.scoreData = Game.scoreData + 100;
                Console.WriteLine(Game.scoreData);
        instance = null;
        Close();
      }
    }

    private void BtnFireball_Click(object sender, EventArgs e){
        if (player.Mana >= 5){
            player.AlterMana(-5);
            player.OnAttack(-6);
            if (enemy.Health > 0){
              enemy.OnAttack(-2);
            }

            UpdateManaBars();
            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0){
              instance = null;
              Close();
            }
        }
    }

    private void EnemyDamage(int amount) {
            enemy.AlterHealth(amount);
            player.AlterStamina(2);
            UpdateStaminaBars();
    }

    private void PlayerDamage(int amount) {
            if (Blocking != true)
            { player.AlterHealth(amount); }
            else
            { player.AlterStamina(-6);
              UpdateStaminaBars();
              Blocking = false;
            }
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

        /// flee button click
        private void BtnFlee_Click(object sender, EventArgs e){ 
            instance = null;
            this.Hide(); }

        /// Defend Button click
        private void BtnDefend_Click(object sender, EventArgs e){
            if (player.Stamina < 4) { Blocking = false; }
            else { 
                Blocking = true;
            }
            UpdateStaminaBars();
        }

        private void BtnHeal_Click(object sender, EventArgs e){
            if (player.Mana >= 5) {
                player.AlterMana(-2);
                UpdateManaBars();
                player.AlterHealth(5);
                UpdateHealthBars();
            }
        }
    }
}
