﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EventPlatFormVer4.Models
{
    public class Participatant
    {
        [Key]
        public uint Id { get; set; }
        public uint RoleID { get; set; }//角色TD:0/1/2

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "姓名必填")]
        public string Name { get; set; }//账号

        [Display(Name = "邮箱地址")]
        [Required(ErrorMessage = "邮箱必填")]
        public string Email { get; set; }

        [Display(Name = "联系方式")]
        [Required(ErrorMessage = "电话必填")]
        public string Phone { get; set; }

        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码必填")]
        public string Pwd { get; set; }//密码


        public Participatant()
        {
            RoleID = 2;

            //Todo  要修改
            Random rm = new Random();
            Id = (uint)rm.Next(100);
        }
    }
    
}
