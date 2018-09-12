        private string XMLStringFromObjSerializer(object obj)
        {
            string str = "";

            str += "<?xml version=\"1.0\"?>\n" +
                "<" + obj.GetType().Name + " xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\n";
            
            //loop through and get all values
            FieldInfo[] fields = obj.GetType().GetFields();
            foreach (FieldInfo f in fields)
            {
                str += "\t<" + f.Name + ">" + f.GetValue(obj) + "</" + f.Name + ">\n";
            }

            //add ending
            str += "</" + obj.GetType().Name + ">";

            return str;
        }
