using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Try and open the chest
            // Verify that  chest is still locked
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }
        [TestMethod]
        public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            //Try to open the chest 
            //Verify that chest is opened
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
    }

}
