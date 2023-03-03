using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;

namespace RoomBookingAppCore
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Response_With_Request_Values()
        {
            //Arrange
            var bookingRequest = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
            Date = new DateTime(2021, 10, 20)
            };
            var processor = new RoomBookingRequestProcessor();
            
            //Act
            RoomBookingResult result = processor.BookRoom(bookingRequest);

            //Assert
            Assert.NotNull(result);
            result.ShouldNotBeNull();
        }

        
    }
}
