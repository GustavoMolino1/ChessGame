//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HalfChessClient
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoveHistory
    {
        public int Id { get; set; }
        public Nullable<int> game_id { get; set; }
        public string move { get; set; }
        public Nullable<int> move_index { get; set; }
    }
}
