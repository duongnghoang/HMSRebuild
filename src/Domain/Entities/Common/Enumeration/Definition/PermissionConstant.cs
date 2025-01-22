namespace Domain.DomainCommon.Enumeration.Definition
{
    /// <summary>
    /// mapping with permision CODE
    /// </summary>
    public static class PermissionConstant
    {
        //public const string Booking = "BOOKING";
        public const string ViewBookingDetail = "VIEW_BOOKING_DETAIL";
        public const string CreateReservation = "CREATE_RESERVATION";
        //public const string ViewTheListOfCardsAndPasscodes = "VIEW_THE_LIST_OF_CARDS_AND_PASSCODES";
        //public const string ViewPasscode = "VIEW_PASSCODE";
        public const string Checkin = "CHECKIN";
        public const string Checkout = "CHECKOUT";
        public const string CheckoutTheLastCheckinRoom = "CHECKOUT_THE_LAST_CHECKIN_ROOM";
        public const string ApplyPastCheckout = "APPLY_PAST_CHECKOUT";
        public const string UndoCheckin = "UNDO_CHECKIN";
        public const string UndoCheckout = "UNDO_CHECKOUT";
        //public const string CreateCardCreateBooking = "CREATE_CARD.CREATE_BOOKING";
        //public const string CreateCardBooked = "CREATE_CARD.BOOKED";
        //public const string CreateCardCheckin = "CREATE_CARD.CHECKIN";
        //public const string EditPriceCreateBooking = "EDIT_PRICE.CREATE_BOOKING";
        //public const string EditPriceBooked = "EDIT_PRICE.BOOKED";
        //public const string EditPriceCheckin = "EDIT_PRICE.CHECKIN";
        //public const string EditRatePlanCreateBooking = "EDIT_RATE_PLAN.CREATE_BOOKING";
        //public const string EditRatePlanBooked = "EDIT_RATE_PLAN.BOOKED";
        //public const string EditRatePlanCheckin = "EDIT_RATE_PLAN.CHECKIN";
        //public const string EditDiscount = "EDIT_DISCOUNT";
        public const string ChangeStayDate = "CHANGE_STAY_DATE";
        public const string AssignUnassignMoveRoom = "ASSIGN_UNASSIGN_MOVEROOM";
        public const string CancelReservation = "CANCEL_RESERVATION";
        //public const string CopyBooking = "COPY_BOOKING";

        //public const string Rooms = "ROOMS";
        public const string RoomRepairCreate = "CREATE_ROOM_REPAIR";
        public const string RoomRepairEdit = "EDIT_ROOM_REPAIR";
        public const string RoomRepairDelete = "DELETE_ROOM_REPAIR";
        public const string ChangeRoomDirty = "CHANGE_ROOM_DIRTY";
        public const string ReservationList = "RESERVATION_LIST";

        //public const string Services = "SERVICES";
        public const string AddServices = "ADD_SERVICES";
        public const string DeleteServices = "DELETE_SERVICES";

        //public const string Payment = "PAYMENT";
        public const string EditPayment = "EDIT_PAYMENT";
        public const string AddPayment = "ADD_PAYMENT";
        public const string DeletePayment = "DELETE_PAYMENT";

        //public const string ReservationReports = "RESERVATION_REPORTS";
        public const string ArrivalList = "ARRIVAL_LIST";
        public const string GuestCheckedIn = "GUEST_CHECKED_IN";
        public const string DepartureList = "DEPARTURE_LIST";

        public const string Cashiering = "CASHIERING";

        public const string AllowAnonymous = "ALLOW_ANONYMOUS";
        //public const string GuestCheckedOut = "GUEST_CHECKED_OUT";
        //public const string InhouseGuestList = "INHOUSE_GUEST_LIST";
    }

    //public enum PermissionEnum
    //{
    //    CreateGuest,
    //    ViewSingleGuest,
    //    SearchGuest,
    //    EditGuest,
    //    DeleteGuest,

    //    AddRole,
    //    ViewSingleRole,
    //    SearchRole,
    //    EditRole,
    //    DeleteRole,

    //    // Reservation Permissions
    //    AddReservation,
    //    ViewSingleReservation,
    //    SearchReservation,
    //    EditReservation,
    //    DeleteReservation
    //}



    //public static class PermissionConversion
    //{
    //    public static string ConvertToString(this PermissionEnum permission)
    //    {
    //        return permission switch
    //        {
    //            PermissionEnum.CreateGuest => PermissionConstant.CreateGuest,
    //            PermissionEnum.ViewSingleGuest => PermissionConstant.ViewSingleGuest,
    //            PermissionEnum.SearchGuest => PermissionConstant.SearchGuest,
    //            PermissionEnum.EditGuest => PermissionConstant.EditGuest,
    //            PermissionEnum.DeleteGuest => PermissionConstant.DeleteGuest,

    //            PermissionEnum.AddRole => PermissionConstant.AddRole,
    //            PermissionEnum.ViewSingleRole => PermissionConstant.ViewSingleRole,
    //            PermissionEnum.SearchRole => PermissionConstant.SearchRole,
    //            PermissionEnum.EditRole => PermissionConstant.EditRole,
    //            PermissionEnum.DeleteRole => PermissionConstant.DeleteRole,

    //            PermissionEnum.AddReservation => PermissionConstant.AddReservation,
    //            PermissionEnum.ViewSingleReservation => PermissionConstant.ViewSingleReservation,
    //            PermissionEnum.SearchReservation => PermissionConstant.SearchReservation,
    //            PermissionEnum.EditReservation => PermissionConstant.EditReservation,
    //            PermissionEnum.DeleteReservation => PermissionConstant.DeleteReservation,

    //            _ => throw new Exception("Not existing Permission")
    //        };
    //    }

    //    public static PermissionEnum PermissionStringToEnum(string permissionString)
    //    {
    //        return permissionString switch
    //        {
    //            PermissionConstant.CreateGuest => PermissionEnum.CreateGuest,
    //            PermissionConstant.ViewSingleGuest => PermissionEnum.ViewSingleGuest,
    //            PermissionConstant.SearchGuest => PermissionEnum.SearchGuest,
    //            PermissionConstant.EditGuest => PermissionEnum.EditGuest,
    //            PermissionConstant.DeleteGuest => PermissionEnum.DeleteGuest,

    //            PermissionConstant.AddRole => PermissionEnum.AddRole,
    //            PermissionConstant.ViewSingleRole => PermissionEnum.ViewSingleRole,
    //            PermissionConstant.SearchRole => PermissionEnum.SearchRole,
    //            PermissionConstant.EditRole => PermissionEnum.EditRole,
    //            PermissionConstant.DeleteRole => PermissionEnum.DeleteRole,

    //            PermissionConstant.AddReservation => PermissionEnum.AddReservation,
    //            PermissionConstant.ViewSingleReservation => PermissionEnum.ViewSingleReservation,
    //            PermissionConstant.SearchReservation => PermissionEnum.SearchReservation,
    //            PermissionConstant.EditReservation => PermissionEnum.EditReservation,
    //            PermissionConstant.DeleteReservation => PermissionEnum.DeleteReservation,

    //            _ => throw new ArgumentException("Not existing Permission", nameof(permissionString))
    //        };
    //    }
    //}
}
