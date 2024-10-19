namespace SingerSongTask
{
    internal class Song
    {
		public double [] Ratings = new double[0];
		private string _name;
		public Singer singer;

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

		private string _genre;

		public string Genre
		{
			get { return _genre; }
			set 
			{
				if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
				{
					_genre = value;
				}
                else
                {
                    Console.WriteLine("Musiqi novu yanlis daxiil edildi , yeniden cehd edin!");
                }
            }
		}
        public Song(string nameSong, string genre, Singer singer)
        {
			_name = nameSong;
			_genre = genre;
			this.singer = singer;
         }
		public void AddRating(double raiting)
		{
			double[] newRatings = new double[Ratings.Length + 1];
            //Ratings =  raitings;
            for (int i = 0; i < Ratings.Length; i++)
			{
				newRatings[i] = Ratings[i];
			}
			newRatings[newRatings.Length - 1] = raiting;
			Ratings = newRatings;
		}
		public void GetAverageRating()
		{
			double sum = 0;
			for (int i = 0; i < Ratings.Length; i++)
			{
                //Ratings[i] = Convert.ToDouble(Console.ReadLine());
                sum += Ratings[i];
			}
			sum /= Ratings.Length;
            Console.WriteLine(sum);
		}


	}
}
