using NUnit.Framework;
namespace RoleplayGame
{

    //No se por que los tests no funcionan, pues estoy usando el mismo namespace que en el resto del proyecto
    //aun asi, me dice que las clases no existen :(

    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void Enfrentamiento1v1GanadorEsperadoHeroe()
        {
            Enemy soyunenemigo = new OrcArcher("Maloso");
            Heroe soybuenito = new Dwarf("Zefrin");
            CombatEncounter combate = new CombatEncounter(new List<Character>{soybuenito}, new List<Character>{soyunenemigo});
            combate.DoEncounter();
            Assert.AreEqual(soyunenemigo.Muerto, true);
            Assert.AreEqual(soybuenito.Muerto, false);
            Assert.AreEqual(soybuenito.PuntosdeVictoria, soyunenemigo.PuntosdeVictoria);
        }

           [Test]
        public void OneManArmy()
        {
            Enemy malo = new OrcoArcher("Gulluk");
            Enemy malo1 = new Orc("Nomr");
            Enemy malo2 = new Orc("Pallock");
            Enemy malo3 = new Orc("Segmur");
            Enemy malo4 = new Orc("E*g+weg##");
            Heroe heroe = new Enano("ElSinDi");
            int vidaEsperada = heroe.Health;
            IItem hacha = new Axe();
            IItem armadura = new Armor();
            heroe.AddItem(hacha);
            heroe.AddItem(armadura);
            heroe.AddItem(armadura);
            CombatEncounter combate = new CombatEncounter( new List<Character>{heroe}, new List<Character>{malo, malo1, malo2, malo3, malo4} );
            combate.DoEncounter();
            Assert.AreEqual(combate.AliveEnemies.Count, 0);
            Assert.AreEqual(combate.AliveHeroes.Count, 1);
            Assert.AreEqual(vidaEsperada, heroe.Health);
        }

         [Test]
        public void EnemigoMuyFuerte()
        {
            Enemy roar = new Dragon("Midir");
            IItem garras = new DragonClaws();
            roar.AddItem(garras);
            roar.AddItem(garras);
            Hero heroe = new Dwarf("Zanahoria");
            Hero heroe1 = new Knight("Parguelin");
            Hero heroe2 = new Archer("Maestro de Parguelin");
            CombatEncounter combate = new CombatEncounter( new List<Character>{heroe, heroe1, heroe2}, new List<Character>{roar} );
            combate.DoEncounter();
            Assert.AreEqual(combate.AliveEnemies.Count, 1);
            Assert.AreEqual(combate.AliveHeroes.Count, 0);
        }

        
    }
}