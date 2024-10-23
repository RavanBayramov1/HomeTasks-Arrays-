namespace Indexer_Array
{
    internal class ListInt
    {
        //private int[] nums;
        private int[] _nums = new int[0];
        //public int[] Nums;
        public int this[int index]
        {
            get => _nums[index];

            set { _nums[index] = value; }
        }
        //public ListInt(int[] nums)
        //{
        //    Nums = nums;
        //}
        public void Add(int num)
        {
            Array.Resize(ref _nums, _nums.Length + 1);
            _nums[^1] = num;
        }
        public void Add(params int[] nums)
        {
            int digit = _nums.Length;
            Array.Resize(ref _nums, nums.Length + _nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                _nums[digit + i] = nums[i];
            }
        }
        public bool Contains(int num)
        {
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        public void Pop()
        {
            Console.WriteLine("Silinen eded:" + _nums[^1]);
            Array.Resize(ref _nums, _nums.Length - 1);
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _nums.Length; i++)
            {
                sum += _nums[i];
            }
            return sum;
        }
        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < _nums.Length; i++)
            {
                text = text + _nums[i] + " ";
            }
            return text;
        }
        public int IndexOf(int num)
        {
            for (int i = 0; i < _nums.Length; i++)
            {
                if (num == _nums[i])
                {
                    return i;
                }
            }
            Console.WriteLine("Bu eded yoxdur");
            return -1;
        }
        public int LastIndexOf(int num)
        {
            int index = -1;
            for(int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i] == num)
                {
                    index = i;
                }
            }
            Console.WriteLine("Eger array-de eded yoxdusa -1 gonderecek");
            return index;
        }
        public void Insert(int num, int index)
        {
            Array.Resize(ref _nums, _nums.Length+1);
            for (int i = _nums.Length-2; i >= index; i--)
            {
                _nums[i + 1] = _nums[i];
            }
             _nums[index] = num;
        }
        public float Average()
        {
            int sum = 0;
            for(int i = 0; i< _nums.Length; i++)
            {
                sum += _nums[i];
            }
            return sum / _nums.Length;
        }
    }
 //1 2 4 9 11 0
}//0 1 2 3 4 5  --> 2
 //1 2 4 4 9 11

//Insert(int num, int index) - Göndərilən elementi daxil olunan indeksə əlavə edib sonrakı elementləri 1 indeks sağa sürüşdürür.
//Average() - Arraydakı elementlərin ədədi ortasını float olaraq geri qaytarır.
