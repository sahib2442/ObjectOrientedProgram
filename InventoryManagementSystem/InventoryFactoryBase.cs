using ObjectOriendedProgram.InventoryManagement;

namespace ObjectOriendedProgram.InventoryManagementSystem
{
    public class InventoryFactoryBase
    {
        public void AddInventory(string inventoryName, InventoryDetails details)
        {
            if (inventoryName == "RiceList")
            {
                this.inventory.RiceList.Add(details);
            }
            if (inventoryName == "WheatList")
            {
                this.inventory.WheatList.Add(details);
            }
            if (inventoryName == "PulsesList")
            {
                this.inventory.PulsesList.Add(details);
            }
        }
    }
}