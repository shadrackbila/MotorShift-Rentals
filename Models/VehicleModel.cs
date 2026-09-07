using System.ComponentModel.DataAnnotations;
using MotorShift_Rentals.Enums;

namespace MotorShift_Rentals.Models
{

    public class VehicleModel
    {
        [Key]
        public Guid? RequestId { get; set; }

        // --- Identity ---
        public VehicleMake Make { get; set; }
        public int Year { get; set; }

        // --- Specs ---
        public int Mileage { get; set; }
        public FuelType FuelType { get; set; }
        public TransmissionType Transmission { get; set; }
        public BodyType BodyType { get; set; }
        public double? EngineSizeLiters { get; set; }

        // --- Financial ---
        public decimal AskingPrice { get; set; }
        public decimal? EstimatedMonthlyInsurance { get; set; }
        public decimal? EstimatedMonthlyMaintenanceCost { get; set; }
        public decimal? EstiatedMontlyTracker { get; set; }


        // --- Condition & History ---
        public TitleStatus TitleStatus { get; set; }
        public int? NumberOfPreviousOwners { get; set; }
        public bool HasAccidentHistory { get; set; }
        public bool HasOutstandingLiens { get; set; }
        public bool ServiceHistoryAvailable { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public bool PassedLastInspection { get; set; }

        // --- Legal / Compliance ---
        public bool IsRegistered { get; set; }
        public DateTime? RegistrationExpiry { get; set; }

        // --- Warranty ---
        public bool HasActiveWarranty { get; set; }
        public DateTime? WarrantyExpiryDate { get; set; }


        // --- Metadata ---
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public string InspectorNotes { get; set; }
    }

    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid,
        PluginHybrid
    }

    public enum TransmissionType
    {
        Automatic,
        Manual,
        CVT
    }

    public enum BodyType
    {
        Bike,
        // Sedan,
        // SUV,
        // Truck,
        // Van,
        // Coupe,
        // Hatchback,
        // Convertible
    }



    public enum TitleStatus
    {
        Clean,
        Salvage,
        Rebuilt,
        Flood,
        Lemon
    }
}