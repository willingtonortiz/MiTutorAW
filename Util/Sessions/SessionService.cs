using MiTutor.Models;

namespace MiTutor.Util.Sessions
{
	public class SessionService
	{
		private static SessionService instance = null;
		public User user { get; set; }

		public static SessionService GetInstance()
		{
			if (instance == null)
			{
				instance = new SessionService();
			}

			return instance;
		}

		private SessionService()
		{
			user = null;
		}
	}
}