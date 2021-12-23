namespace C_Sharp_Basics {


    class Robot {

        // поля класса - private или protected, доступ к полям через аксессоры или конструктор - это реализация инкапсуляции
        private string name = "Default";
        private int weight = 0;
        private int[] coords = new int[] {0, 0, 0};

        // аксессоры для полей класса
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public int[] Coords { get => coords; set => coords = value; }

        //констркутор - всегда public, тип возвращаемого значения не указывается
        public Robot(string _name, int _weight, int[] _coords) {
            this.name = _name;
            this.weight = _weight;
            this.coords = _coords;
        }
    }
}