     static string ParseStringToUkPostcode(string inputPostcode)
    {
        string outputPostcode = inputPostcode;

        outputPostcode = outputPostcode.Replace(" ", "").Trim();
        string outward = outputPostcode.Substring(0, outputPostcode.Length - 3);
        string inward = outputPostcode.Substring(Math.Max(0, outputPostcode.Length - 3));
        string postcode = string.Format("{0} {1}", outward, inward);
        outputPostcode = postcode;

        return outputPostcode;
    }
     bool PostCodeRegex(String postcode)
    {
        string _postcode = postcode;
        string pattern = @"^([A-Za-z][A-Ha-hJ-Yj-y]?[0-9][A-Za-z0-9]? ?[0-9][A-Za-z]{2}|[Gg][Ii][Rr] ?0[Aa]{2})$";

        /*string substitution = "$1 $2";
        RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;
        Regex regex = new Regex(pattern, options);
        string result = regex.Replace(_postcode, substitution);
        return result;*/
        Regex ukPostRegex = new Regex(pattern, RegexOptions.Compiled);
        Match match = ukPostRegex.Match(_postcode);

        if (match.Success)
        {
            return true;
        }
        else
        {
            return false;
        }
    }