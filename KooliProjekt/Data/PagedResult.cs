<<<<<<< HEAD
﻿using System.Security.Policy;

namespace KooliProjekt.Data
=======
﻿namespace KooliProjekt.Data
>>>>>>> 3ab08cc95858c0f3d4ab2d2123111f2da03c6471
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 3ab08cc95858c0f3d4ab2d2123111f2da03c6471
