// було порушено принцип єдиної відповідальності

namespace DZ8
{
    class Item
    {
    }
    class Order
    {
        private List<Item> itemList;
        public List<Item> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }

        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderCalculator
    {
        public void CalculateTotalSum(Order order) {/*...*/}
    }

    class OrderStorage
    {
        public void Load(Order order) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }

    class OrderDisplay
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }

}
