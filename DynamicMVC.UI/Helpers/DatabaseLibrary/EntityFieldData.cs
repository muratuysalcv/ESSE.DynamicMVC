using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EntityFieldData
/// </summary>
public class EntityFieldData {
    public EntityFieldData() {
        ERRORS = new List<string>();
    }
    public string COLUMN_NAME { get; set; }
    public string COLUMN_VALUE { get; set; }
    public string COLUMN_TYPE { get; set; }
    public string FOREIGN_ENTITY_NAME { get; set; }

    public List<string> ERRORS { get; set; }

    public bool IS_VALID {
        get {
            return this.ERRORS.Count == 0;
        }
    }
}

public enum COLUMN_TYPES {
    BOOLEAN,
    INTEGER,
    DECIMAL,
    TEXT,
    HTML_TEXT,
    SQL_CODE,
    JSON_CODE
}