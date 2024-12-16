using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.User;
using api.Models;

namespace api.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                Id = userModel.Id,
                FullName = userModel.FullName,
                Email = userModel.Email,
                UserName = userModel.UserName,
                PhoneNumber = userModel.PhoneNumber,
                DateOfBirth = userModel.DateOfBirth,
                Gender = userModel.Gender,
                Role = userModel.Role,
                RegisteredAt = userModel.RegisteredAt,
                LastLogin = userModel.LastLogin,
                IsActive = userModel.IsActive
            };
        }
        public static User ToUserFromCreate(this CreateUserDto userDto)
        {
            return new User
            {
                FullName = userDto.FullName,
                Email = userDto.Email,
                UserName = userDto.UserName,
                Password = userDto.Password,
                PhoneNumber = userDto.PhoneNumber,
                DateOfBirth = userDto.DateOfBirth
            };
        }

        public static User ToUserFromUpdate(this UpdateUserDto userDto)
        {
            return new User
            {
                FullName = userDto.FullName,
                Email = userDto.Email,
                UserName = userDto.UserName,
                Password = userDto.Password,
                PhoneNumber = userDto.PhoneNumber,
                DateOfBirth = userDto.DateOfBirth
            };
        }
    }
}