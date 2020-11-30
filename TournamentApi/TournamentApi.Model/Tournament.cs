using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TournamentApi.Model
{
    public class Tournament
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TournamentId { get; set; }
    }
}
