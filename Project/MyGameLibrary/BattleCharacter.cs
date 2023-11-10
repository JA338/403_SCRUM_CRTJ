using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; }
    protected float strength;

    public int Stamina { get; protected set; }
    public int MaxStamina { get; protected set; }

    public int Mana {  get; protected set; }
    public int MaxMana { get; protected set; }

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;

      MaxStamina = 15;
      Stamina = MaxStamina;

      MaxMana = 10;
      Mana = MaxMana;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void AlterStamina(int amount) { 
      Stamina += (int)(amount);
      if (Stamina > MaxStamina) { Stamina = MaxStamina; }
      if (Stamina < 0) { Stamina = 0; }
        }
  }
}
