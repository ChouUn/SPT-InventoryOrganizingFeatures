using EFT.InventoryLogic;
using ContainerFilter = GClass3124; // GClass2928 in SPT-AKI 3.14.x

namespace ChouUn.Iof
{
    internal static class Extensions
    {
        public static bool CanAccept(this StashGridClass grid, Item item)
        {
            // find the class using [CheckItemExcludedFilter, CheckItemFilter, CanAccept]
            return ContainerFilter.CanAccept(grid, item);
        }
    }
}
