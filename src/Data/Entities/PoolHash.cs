using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class PoolHash
    {
        public PoolHash()
        {
            #region Generated Constructor
            Delegations = new HashSet<Delegation>();
            HashPoolRetires = new HashSet<PoolRetire>();
            HashPoolUpdates = new HashSet<PoolUpdate>();
            PoolEpochStakes = new HashSet<EpochStake>();
            PoolOwners = new HashSet<PoolOwner>();
            PoolRewards = new HashSet<Reward>();
            SlotLeaders = new HashSet<SlotLeader>();
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] HashRaw { get; set; }

        public string View { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Delegation> Delegations { get; set; }

        public virtual ICollection<PoolRetire> HashPoolRetires { get; set; }

        public virtual ICollection<PoolUpdate> HashPoolUpdates { get; set; }

        public virtual ICollection<EpochStake> PoolEpochStakes { get; set; }

        public virtual ICollection<PoolOwner> PoolOwners { get; set; }

        public virtual ICollection<Reward> PoolRewards { get; set; }

        public virtual ICollection<SlotLeader> SlotLeaders { get; set; }

        #endregion

    }
}
