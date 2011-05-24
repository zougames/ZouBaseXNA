/* 
 * (MIT License)
 * Author: Sadjow Medeiros Leão <sadjow@gmail.com>
 * Author: Waldson Patrício do Nascimento Leandro <waldsonpatricio@gmail.com>
 * Created on Monday - 23/05/2011
 * http://zougames.org
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace org.zougames.Input
{

    public enum Category
    {
        COMMAND,
        SPECIAL,
        BLITZ,
        MEGA_BLIZ
    }

    /// <summary>
    /// Descreve uma sequencia de botões ao qual deve ser precionada para ativar o movimento.
    /// </summary>
    public class Move
    {
        /// <summary>
        /// Nome do movimento.
        /// </summary>
        public string Name;

        /// <summary>
        /// A sequencia de botões precionados para ativar este Move.
        /// </summary>
        public GameKeys[] Sequence;

        /// <summary>
        /// Defina isto como true se o input usado para ativar este move servir
        /// para ativar um longo Move.
        /// </summary>
        public bool IsSubMove;


        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }



        private Category _category;
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Constroi um novo movimento.
        /// </summary>
        /// <param name="name">Nome do movimento</param>
        /// <param name="sequence">Sequencia de botões a serem precionados</param>
        public Move(string name, string display_name, Category category, params GameKeys[] sequence)
        {
            Name = name;
            DisplayName = display_name;
            Category = category;
            Sequence = sequence;
        }

    }
}
