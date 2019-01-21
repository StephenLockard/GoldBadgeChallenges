using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_challenge
{
    public class ClaimRepository
    {
        List<Claim> claimList = new List<Claim>();

        public void AppendToList(Claim claim)
        {
            claimList.Add(claim);
        }

        public void RemoveFromList(Claim claim)
        {
            claimList.Remove(claim);
        }

        public List<Claim> GetList()
        {
            return claimList;
        }

        public void RemoveSpecificItem(int claimID)
        {
            foreach (Claim claim in claimList)
            {
                if (claim.ClaimID == claimID)
                {
                    RemoveFromList(claim);
                    break;

                }

            }
        }
    }
}
