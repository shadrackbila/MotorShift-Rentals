using System.ComponentModel.DataAnnotations;

namespace MotorShift_Rentals.Models
{
    public class VehiclePurchaseEvaluation
    {

        [Key]
        public Guid EvaluationId { get; set; }

        // --- Link back to the vehicle being evaluated ---
        public Guid RequestId { get; set; }
        public VehicleModel Vehicle { get; set; }

        // --- Budget / Financial thresholds ---
        public decimal MaxBudget { get; set; }
        public decimal EstimatedTotalCostOfOwnership { get; set; }
        public bool WithinBudget { get; set; }

        // --- Age / Mileage thresholds ---
        public int MaxAcceptableAgeYears { get; set; }
        public int MaxAcceptableMileage { get; set; }
        public bool AgeAcceptable { get; set; }
        public bool MileageAcceptable { get; set; }

        // --- Condition & History checks ---
        public bool RequireCleanTitle { get; set; } = true;
        public bool TitleCheckPassed { get; set; }
        public bool RequireNoAccidentHistory { get; set; } = true;
        public bool AccidentHistoryCheckPassed { get; set; }
        public bool RequireNoOutstandingLiens { get; set; } = true;
        public bool LienCheckPassed { get; set; }
        public int MaxAcceptablePreviousOwners { get; set; }
        public bool OwnerCountAcceptable { get; set; }

        // --- Legal / Compliance checks ---
        public bool RequireValidRegistration { get; set; } = true;
        public bool RegistrationCheckPassed { get; set; }



        // --- Scoring / Weighting (optional, for a scored model instead of pure pass/fail) ---
        public int? OverallScore { get; set; }
        public int? MinimumPassingScore { get; set; }

        // --- Final Decision ---
        public PurchaseDecision Decision { get; set; }
        public string DecisionReason { get; set; }
        public DateTime EvaluatedOn { get; set; } = DateTime.UtcNow;
        public string EvaluatedBy { get; set; }
    }

    public enum PurchaseDecision
    {
        Pending,
        Approved,
        Rejected,
        NeedsFurtherReview
    }

}
