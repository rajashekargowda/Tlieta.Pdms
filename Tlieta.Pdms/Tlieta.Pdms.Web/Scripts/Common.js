
//spell check
//$Spelling.SpellCheckAsYouType('all');

// Handle Json date conversion
var prependZero = function (v) {
    v = v.toString();
    return (v.length == 1) ? "0" + v : v;
};

var dateDeserialize = function (dateStr) {
    var dt = new Date(parseInt(dateStr.substr(6)));
    return prependZero((dt.getMonth() + 1))
        + "/" + prependZero(dt.getDate())
        + "/" + dt.getFullYear();
    //+ " " + prependZero(dt.getHours())
    //+ ":" + prependZero(dt.getMinutes())
    //+ ":" + prependZero(dt.getSeconds());
};

//check is null or empty
function isNullAndUndefined(o) {
    if (o !== null && o !== undefined) {
        return false;
    }
    return true;
}
function isNullAndEmpty(o) {
    alert(o);
    if (o !== null && o.trim().length > 0) {
        return false;
    }
    return true;
}


function disableEvent() {
    return false;
}

function getKey(e) {
    if (window.event)
        return window.event.keyCode;
    else if (e)
        return e.which;
    else
        return null;
}
function decimalNumberValidation(e, obj) {
    var CHAR_AFTER_DP = 2;  // number of decimal places  
    var validList = "0123456789.";  // allowed characters in field  
    var key, keyChar;
    key = getKey(e);
    if (key == null) return true;
    // control keys  
    // null, backspace, tab, carriage return, escape  
    if (key == 0 || key == 8 || key == 9 || key == 13 || key == 27)
        return true;
    // get character  
    keyChar = String.fromCharCode(key);
    // check valid characters  
    if (validList.indexOf(keyChar) != -1) {
        // check for existing decimal point  
        var dp = 0;
        if ((dp = obj.value.indexOf(".")) > -1) {
            if (keyChar == ".")
                return false;  // only one allowed  
            else {
                // room for more after decimal point?  
                if (obj.value.length - dp <= CHAR_AFTER_DP)
                    return true;
            }
        }
        else return true;
    }
    // not a valid character  
    return false;
}

// Reference : http://vikku.info/codesnippets/javascript/us-phone-number-validation-by-adding-hypen-automatically-using-javascript/
//function mask(e, f) {
//    var len = f.value.length;
//    var key = whichKey(e);
//    if (key > 47 && key < 58) {
//        //if (len == 3) f.value = f.value + '-'
//        //else if (len == 7) f.value = f.value + '-'
//        if (len == 3) f.value = '(' + f.value + ')'
//        else if (len == 8) f.value = f.value + '-'
//        else f.value = f.value;
//    }
//    else {
//        f.value = f.value.replace(/[^0-9-]/, '')
//        f.value = f.value.replace('--', '-')
//    }
//}

//function whichKey(e) {
//    var code;
//    if (!e) var e = window.event;
//    if (e.keyCode) code = e.keyCode;
//    else if (e.which) code = e.which;
//    return code
//}
//Reference : http://social.msdn.microsoft.com/Forums/en-US/658567b9-678a-4c94-bff6-c439f5ff3501/float-validation-on-keypress-event
//Reference :  http://www.codeproject.com/Articles/19923/Password-pattern-check-using-javascript
function validatePassword(fieldName, minNumberOfDigits, maxNumberOfDigits) {
    
    if (fieldName.value.length > 0) {
        var alphaNumericPattern = "^[a-z0-9/_/!#%^&*()~@@$]{" +
            minNumberOfDigits + "," + maxNumberOfDigits + "}";
        var regExpr = new RegExp(alphaNumericPattern, "i");
        var sourceField = event != null ? event.srcElement : e.target;
        if (fieldName != null && fieldName != "null" && fieldName != "undefined") {
            sourceField = fieldName.value;//document.getElementById(fieldName);
        }

        var message = "Password must be minimum 8 characters in length and must contain atleast 1 alphabet 1 number and 1 special character.";
        //message = message + "\n and must be between " + minNumberOfDigits +
        //        " and " + maxNumberOfDigits + " chars.";
        var sourceFieldValue = sourceField;

        if (sourceFieldValue.length < minNumberOfDigits ||
                   sourceFieldValue.length > maxNumberOfDigits) {
            alert(message);
            //    sourceField.focus();
            fieldName.focus();
            return false;
        }
        if (!regExpr.test(sourceFieldValue)) {
            alert(message);
            //sourceField.focus();
            fieldName.focus();
            return false;
        }
        //regExpr = new RegExp("[a-z/_/$]{1}", "i");
        regExpr = new RegExp("[a-z]{1}", "i");
        if (!regExpr.test(sourceFieldValue)) {
            alert(message);
            //sourceField.focus();
            fieldName.focus();
            return false;
        }
        regExpr = new RegExp("[0-9]{1}", "i");
        if (!regExpr.test(sourceFieldValue)) {
            alert(message);
            //sourceField.focus();
            fieldName.focus();
            return false;
        }
        regExpr = new RegExp("[/!#%^&*()~_/@@$]{1}", "i");
        if (!regExpr.test(sourceFieldValue)) {
            alert(message);
            //sourceField.focus();
            fieldName.focus();
            return false;
        }
    }
}


var zChar = new Array(' ', '(', ')', '-', '.');
var maxphonelength = 14;
var phonevalue1;
var phonevalue2;
var cursorposition;

function backspacerDOWN(object, e) {
    if (e) {
        e = e;
    } else {
        e = window.event;
    }
    var keycode = null;
    if (e.which) {
        keycode = e.which;
    } else {
        keycode = e.keyCode;
    }
    ParseForNumber2(object);
}
function ParseForNumber1(object) {
    phonevalue1 = ParseChar(object.value, zChar);
}
function ParseForNumber2(object) {
    phonevalue2 = ParseChar(object.value, zChar);
}

function backspacerUP(object, e) {
    if (e) {
        e = e;
    } else {
        e = window.event;
    }
    var keycode;
    if (e.which) {
        keycode = e.which;
    } else {
        keycode = e.keyCode;
    }

    ParseForNumber1(object);

    if (keycode >= 48) {
        ValidatePhone(object);
    }
}

function ValidatePhone(object) {

    var p = phonevalue1;

    p = p.replace(/[^\d]*/gi, "");

    if (p.length < 3) {
        object.value = p;
    } else if (p.length == 3) {
        pp = p;
        d4 = p.indexOf('(');
        d5 = p.indexOf(')');
        if (d4 == -1) {
            pp = "(" + pp;
        }
        if (d5 == -1) {
            pp = pp + ")";
        }
        object.value = pp;
    } else if (p.length > 3 && p.length < 8) {
        p = "(" + p;
        l30 = p.length;
        p30 = p.substring(0, 4);
        p30 = p30 + ")"
        p31 = p.substring(4, l30);
        pp = p30 + p31;

        object.value = pp;

    } else if (p.length >= 8) {
        p = "(" + p;
        l30 = p.length;
        p30 = p.substring(0, 4);
        p30 = p30 + ")";
        p31 = p30 + " ";
        l30 = p.length;
        p32 = p.substring(4, l30);
        pp = p31 + p32;

        l40 = pp.length;
        p40 = pp.substring(0, 9);
        p40 = p40 + "-";

        p41 = pp.substring(9, l40);
        ppp = p40 + p41;

        object.value = ppp.substring(0, maxphonelength);
    }

    GetCursorPosition();

    if (cursorposition >= 0) {
        if (cursorposition == 0) {
            cursorposition = 2;
        } else if (cursorposition <= 2) {
            cursorposition = cursorposition + 1;
        } else if (cursorposition <= 5) {
            cursorposition = cursorposition + 2;
        } else if (cursorposition == 6) {
            cursorposition = cursorposition + 2;
        } else if (cursorposition == 7) {
            cursorposition = cursorposition + 4;
            e1 = object.value.indexOf(')');
            e2 = object.value.indexOf('-');
            if (e1 > -1 && e2 > -1) {
                if (e2 - e1 == 4) {
                    cursorposition = cursorposition - 1;
                }
            }
        } else if (cursorposition < 11) {
            cursorposition = cursorposition + 3;
        } else if (cursorposition == 11) {
            cursorposition = cursorposition + 3;
        } else if (cursorposition >= 14) {
            cursorposition = cursorposition;
        }

        var txtRange = object.createTextRange();
        txtRange.moveStart("character", cursorposition);
        txtRange.moveEnd("character", cursorposition - object.value.length);
        txtRange.select();
    }

}
function GetCursorPosition() {

    var t1 = phonevalue1;
    var t2 = phonevalue2;
    var bool = false;
    for (i = 0; i < t1.length; i++) {
        if (t1.substring(i, 1) != t2.substring(i, 1)) {
            if (!bool) {
                cursorposition = i;
                bool = true;
            }
        }
    }
}
function ParseChar(sStr, sChar) {
    if (sChar.length == null) {
        zChar = new Array(sChar);
    }
    else zChar = sChar;

    for (i = 0; i < zChar.length; i++) {
        sNewStr = "";

        var iStart = 0;
        var iEnd = sStr.indexOf(sChar[i]);

        while (iEnd != -1) {
            sNewStr += sStr.substring(iStart, iEnd);
            iStart = iEnd + 1;
            iEnd = sStr.indexOf(sChar[i], iStart);
        }
        sNewStr += sStr.substring(sStr.lastIndexOf(sChar[i]) + 1, sStr.length);

        sStr = sNewStr;
    }

    return sNewStr;
}

function isNumber(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}


function ValidateEmail(e) {
    var filter = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/;
    return String(e).search(filter) != -1;
}
function ValidateUrl(e) {
    var filter = /(http|https|ftp|ftps)\:\/\/[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(\/\S*)?/;
    return String(e).search(filter) != -1;
}

function chkEmail(str) {

    var at = "@"
    var dot = "."
    var lat = str.indexOf(at)
    var lstr = str.length
    var ldot = str.indexOf(dot)

    if (str.indexOf(at) == -1)
    { return false }

    if (str.indexOf(at) == -1 || str.indexOf(at) == lstr)
    { return false }

    if (str.indexOf(dot) == -1 || str.indexOf(dot) == lstr) {
        return false
    }
    if (str.indexOf(at, (lat + 1)) != -1) {
        return false
    }

    if (str.substring(lat - 1, lat) == dot || str.substring(lat + 1, lat + 2) == dot) {
        return false
    }

    if (str.indexOf(dot, (lat + 2)) == -1) { //-1
        return false
    }

    if (str.indexOf(" ") != -1)
    { return false }

    return true;
}

function trim(s) {
    return rtrim(ltrim(s));
}

function ltrim(s) {
    var l = 0;
    while (l < s.length && s[l] == ' ')
    { l++; }
    return s.substring(l, s.length);
}

function rtrim(s) {
    var r = s.length - 1;
    while (r > 0 && s[r] == ' ')
    { r -= 1; }
    return s.substring(0, r + 1);
}

function showHide(divId) {

    var theDiv = document.getElementById(divId);
    if (theDiv.style.display == "none") {
        theDiv.style.display = "";
    } else {
        theDiv.style.display = "none";
    }
}
function SetFocus(obj) {
    setTimeout(
        function () { document.getElementById(obj).focus() }, 10);
}

function validateNumericZipCode(event) {
    if ((event.keyCode != 45) && (event.keyCode < 48 || event.keyCode > 57)) event.returnValue = false;
    else {
        if ((event.which != 45) && (event.which < 48 || event.which > 57)) return false;
    }
}
function isValidUSZip(sZip) {
        return /^\d{5}(-\d{4})?$/.test(sZip);
}

function isValidPhoneNumber(phoneValue) {
    var s2 = ("" + phoneValue).replace(/\D/g, '');
    var m = s2.match(/^(\d{3})(\d{3})(\d{4})$/);
    if (!m) {
        return false;
    }
    else {
        return true;
    }
}


//////////////////////////////////////////////////////////////////////
/////////// Kendo Grid manipulations /////////////////////////////////

function getCheckedItems(entityGrid)
{
    var data = entityGrid.dataSource.data();
    var totalNumber = data.length;
    var currentDataItem = null;
    for (var item in checkedIds) {
        if (checkedIds[item] == true) {
            if (currentDataItem == null) {
                currentDataItem = item;
            }
            else {
                currentDataItem += "!" + item;
            }
        }
    }
    return currentDataItem;
}
function save(message) {
    var retVal = confirm(message);
    if (retVal) {
        return true;
    }
    else {
        return false;
    }
}
function cancel(message) {
    var retVal = confirm(message);
    if (retVal) {
        return true;
    }
    else {
        return false;
    }
}


function NumberswithDecimals(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode != 46 && charCode > 31
      && (charCode < 48 || charCode > 57))
        return false;

    return true;
}

function NumberswithTwoDecimals(evt) {
    if (!(evt.keyCode == 46 || (evt.keyCode >= 48 && evt.keyCode <= 57))) return false;
    var parts = evt.srcElement.value.split('.');
    if (parts.length > 2) return false;
    if (evt.keyCode == 46) return (parts.length == 1);
    if (parts[0].length >= 14) return false;
    if (parts.length == 2 && parts[1].length >= 2) return false;
}

function NumberswithThreeDecimals(evt) {
    if (!(evt.keyCode == 46 || (evt.keyCode >= 48 && evt.keyCode <= 57))) return false;
    var parts = evt.srcElement.value.split('.');
    if (parts.length > 2) return false;
    if (evt.keyCode == 46) return (parts.length == 1);
    if (parts[0].length >= 14) return false;
    if (parts.length == 2 && parts[1].length >= 3) return false;
}


//////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////

function isValidEmailAddress(emailAddress) {
    var pattern =new RegExp(/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/);
    // new RegExp(/^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/i);
    return pattern.test(emailAddress);
}

function validatePhoneNumber(phoneValue, firstItem) {

    //var PNum = new String(phoneValue);
    //var regex2 =/^[0-9]{3,3}\-[0-9]{3,3}\-[0-9]{4,4}$|^\([0-9]{3,3}\)[0-9]{3,3}\-[0-9]{4,4}$|^\([0-9]{3,3}\)[0-9]{3,3}\-[0-9]{4,4}$|^[0-9]{3,3}\-[0-9]{4,4}$/;

    //var regex = /^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$/;
    //return m.test(PNum);
    var s2 = ("" + phoneValue).replace(/\D/g, '');
    var m = s2.match(/^(\d{3})(\d{3})(\d{4})$/);
    if (!m) {
        return false;
    }
    else {
        firstItem.set('Details', "(" + m[1] + ") " + m[2] + "-" + m[3]);
        //data = "(" + m[1] + ") " + m[2] + "-" + m[3];
        return true;
    }
}
function ValidateDeliveryMethodInfoGrid(div) {

    
    var entityGrid = $("#DeliveryMethodInfoGrid").data("kendoGrid");

    var data = entityGrid.dataSource.data();
    var totalNumber = data.length;
    var isValid = true;
    if (totalNumber == 0)
        return true;

    for (var i = 0; i < totalNumber; i++) {
     
        var currentDataItem = data[i];

        var deliveryMethod = currentDataItem.Methods.Value;
        var detailsEntered = currentDataItem.Details;

        if (deliveryMethod == 'Fax' || deliveryMethod == 'Phone') {
            var firstItem = $('#DeliveryMethodInfoGrid').data().kendoGrid.dataSource.data()[i];
            if (!validatePhoneNumber(detailsEntered, firstItem)) {

                //alert(detailsEntered + " is not a valid fax / phone number");
                if(deliveryMethod=="Fax")
                {
                    div.innerHTML += "Please enter a valid Fax number."
                }
                else if (deliveryMethod == "Phone") {
                    div.innerHTML += "Please enter a valid Phone number."
                }
                isValid = false;
                break;
            }
            else {

            }
        }
        
       
        if (deliveryMethod == "FTP Address") {
           
            if (!ValidateUrl(detailsEntered)) {
                {
                    div.innerHTML += "Should be an FTP address validator."
                    isValid = false;
                    break;
                }
            }
        }

        if (deliveryMethod == 'Email') {
            if (!isValidEmailAddress(detailsEntered)) {
                //alert("Not a valid email address");
                div.innerHTML += "Should be an email address validator."
                isValid = false;
                break;
            }
            //else { return true; }
        }

        //if (deliveryMethod == 'Web Address') {
        //    if (!validateWeb(detailsEntered)) {
        //        //alert("Not a valid web address");
        //        div.innerHTML += "Should be an valid web address validator."
        //        isValid = false;
        //        break;
        //    }
        //    //else { return true; }
        //}
    }
    if (!isValid) {
        return false;
    }
    else {
        return true;
    }
}
function isUrl(s) {
    if (s != "") {
        var theUrl = s;
        if (theUrl.match(/((http|ftp|https)\:\/\/)??\w+([\.\-]\w+)*\.\w{2,4}(\:\d+)*([\/\.\-\?\&\%\#]\w+)*\/?$/i) ||
        theUrl.match(/^mailto\:\w+([\.\-]\w+)*\@@\w+([\.\-]\w+)*\.\w{2,4}$/i)) {
            return true;
        }
        else {

            return false;
        }
    }

}

function isDate(dateReceived) {

    if (dateReceived.length > 6) {
        var checkDate = new Date(Date.parse(dateReceived));

        if (checkDate == "Invalid Date") {
            return false;
        }

        else {
            return true;
        }
    }
    else {
        return false;
    }    
}