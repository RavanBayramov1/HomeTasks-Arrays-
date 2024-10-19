namespace SingerSongTask
{
    internal class Singer
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set
            {
                if (value.Length <= 100)
                {
					_name = value; 
                }
                else
                {
                    Console.WriteLine("Ad yanlis daxiil edildi , yeniden cehd edin!");
                }
            }
		}
		private string _surname;

		public string Surname
		{
			get { return _surname; }
			set
			{
				if (value.Length <= 100)
				{
					_surname = value;
				}
                else
                {
                    Console.WriteLine("Soyad yanlis daxiil edildi , yeniden cehd edin!");
                }
            }
		}
		private int _age;

		public int Age
		{
			get { return _age; }
			set 
			{
				if(value <= 170) 
				{
				_age = value; 				
				}
				else
				{
                    Console.WriteLine("Yas yanlis daxiil edildi , yeniden cehd edin!");
				}
			}
		}
        public Singer(string nameSinger,string surnameSinger,int ageSinger)
        {
            Age = ageSinger;	
			Name = nameSinger;
			Surname = surnameSinger;
        }

    }
}
