///  @file    TestGetMultipleObjects.cs
///  @brief   GetMultipleObjects unit tests
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Sarah Keating
 
///  
///  ====== WARNING ===== WARNING ===== WARNING ===== WARNING ===== WARNING ======
/// 
///  DO NOT EDIT THIS FILE.
/// 
///  This file was generated automatically by converting the file located at
///  src/sbml/test/TestGetMultipleObjects.cpp
///  using the conversion program dev/utilities/translateTests/translateTests.pl.
///  Any changes made here will be lost the next time the file is regenerated.
/// 
///  -----------------------------------------------------------------------------
///  This file is part of libSBML.  Please visit http://sbml.org for more
///  information about SBML, and the latest version of libSBML.
/// 
///  Copyright 2005-2010 California Institute of Technology.
///  Copyright 2002-2005 California Institute of Technology and
///                      Japan Science and Technology Corporation.
///  
///  This library is free software; you can redistribute it and/or modify it
///  under the terms of the GNU Lesser General Public License as published by
///  the Free Software Foundation.  A copy of the license agreement is provided
///  in the file named "LICENSE.txt" included with this software distribution
///  and also available online as http://sbml.org/software/libsbml/license.html
///  -----------------------------------------------------------------------------


namespace LibSBMLCSTest.sbml {

  using libsbmlcs;

  using System;

  using System.IO;

  public class TestGetMultipleObjects {
    public class AssertionError : System.Exception 
    {
      public AssertionError() : base()
      {
        
      }
    }


    static void assertTrue(bool condition)
    {
      if (condition == true)
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        return;
      }
      else if ( (a == null) || (b == null) )
      {
        throw new AssertionError();
      }
      else if (a.Equals(b))
      {
        return;
      }
  
      throw new AssertionError();
    }

    static void assertNotEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        throw new AssertionError();
      }
      else if ( (a == null) || (b == null) )
      {
        return;
      }
      else if (a.Equals(b))
      {
        throw new AssertionError();
      }
    }

    static void assertEquals(bool a, bool b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(bool a, bool b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(int a, int b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(int a, int b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }


    public void test_GetMultipleObjects_allElements()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/test/test-data/";
      filename += "multiple-ids.xml";
      d = reader.readSBML(filename);
      if (d == null);
      {
      }
      SBaseList list = d.getListOfAllElements();
      assertTrue( list.getSize() == 37 );
      d = null;
    }

    public void test_GetMultipleObjects_getId()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/test/test-data/";
      filename += "multiple-ids.xml";
      d = reader.readSBML(filename);
      if (d == null);
      {
      }
      SBase obj = d.getElementBySId("no_id");
      assertTrue( obj == null );
      obj = d.getElementBySId("");
      assertTrue( obj == null );
      obj = d.getElementBySId("find_id");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_MODEL );
      obj = d.getElementBySId("func1");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_FUNCTION_DEFINITION );
      obj = d.getElementBySId("comp");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_COMPARTMENT );
      obj = d.getElementBySId("b");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_SPECIES );
      obj = d.getElementBySId("x");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_PARAMETER );
      obj = d.getElementBySId("J0");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_REACTION );
      obj = d.getElementBySId("E0");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_EVENT );
      d = null;
    }

    public void test_GetMultipleObjects_getMetaId()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/test/test-data/";
      filename += "multiple-ids.xml";
      d = reader.readSBML(filename);
      if (d == null);
      {
      }
      SBase obj = d.getElementByMetaId("no_id");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("meta1");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_DOCUMENT );
      obj = d.getElementByMetaId("meta2");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_MODEL );
      obj = d.getElementByMetaId("meta3");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_COMPARTMENT );
      obj = d.getElementByMetaId("meta4");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_COMPARTMENT );
      obj = d.getElementByMetaId("meta5");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_SPECIES );
      obj = d.getElementByMetaId("meta6");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_SPECIES );
      obj = d.getElementByMetaId("meta7");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_REACTION );
      obj = d.getElementByMetaId("meta8");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_REACTION );
      obj = d.getElementByMetaId("meta9");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_SPECIES_REFERENCE );
      obj = d.getElementByMetaId("meta10");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_SPECIES_REFERENCE );
      obj = d.getElementByMetaId("meta11");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_KINETIC_LAW );
      obj = d.getElementByMetaId("meta12");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_EVENT );
      obj = d.getElementByMetaId("meta13");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_EVENT );
      obj = d.getElementByMetaId("meta14");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_TRIGGER );
      obj = d.getElementByMetaId("meta15");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_EVENT_ASSIGNMENT );
      obj = d.getElementByMetaId("meta16");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_EVENT_ASSIGNMENT );
      obj = d.getElementByMetaId("meta17");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_DELAY );
      obj = d.getElementByMetaId("meta18");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_PARAMETER );
      obj = d.getElementByMetaId("meta19");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_PRIORITY );
      obj = d.getElementByMetaId("meta20");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_FUNCTION_DEFINITION );
      obj = d.getElementByMetaId("meta21");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_FUNCTION_DEFINITION );
      obj = d.getElementByMetaId("meta22");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_INITIAL_ASSIGNMENT );
      obj = d.getElementByMetaId("meta23");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_INITIAL_ASSIGNMENT );
      obj = d.getElementByMetaId("meta24");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_RULE );
      obj = d.getElementByMetaId("meta25");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_RATE_RULE );
      obj = d.getElementByMetaId("meta26");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_ASSIGNMENT_RULE );
      obj = d.getElementByMetaId("meta27");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_LOCAL_PARAMETER );
      obj = d.getElementByMetaId("meta28");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LOCAL_PARAMETER );
      obj = d.getElementByMetaId("meta29");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_UNIT_DEFINITION );
      obj = d.getElementByMetaId("meta30");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_UNIT_DEFINITION );
      obj = d.getElementByMetaId("meta31");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_UNIT );
      obj = d.getElementByMetaId("meta32");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_UNIT );
      obj = d.getElementByMetaId("meta33");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_PARAMETER );
      obj = d.getElementByMetaId("meta34");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LIST_OF );
      assertTrue( ((ListOf) obj).getItemTypeCode() == libsbml.SBML_MODIFIER_SPECIES_REFERENCE );
      obj = d.getElementByMetaId("meta35");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_MODIFIER_SPECIES_REFERENCE );
      d = null;
    }

    public void test_GetMultipleObjects_noAssignments()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/test/test-data/";
      filename += "assignments-invalid.xml";
      d = reader.readSBML(filename);
      if (d.getModel() == null);
      {
      }
      SBase obj = d.getElementBySId("ia");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("ia_meta");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_INITIAL_ASSIGNMENT );
      obj = d.getElementBySId("ar");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("ar_meta");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_ASSIGNMENT_RULE );
      obj = d.getElementBySId("rr");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("rr_meta");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_RATE_RULE );
      obj = d.getElementBySId("ea");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("ea_meta");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_EVENT_ASSIGNMENT );
      d = null;
    }

    public void test_GetMultipleObjects_noLocalParameters()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/test/test-data/";
      filename += "multiple-ids.xml";
      d = reader.readSBML(filename);
      if (d == null);
      {
      }
      SBase rxn = d.getElementBySId("J0");
      assertTrue( rxn != null );
      SBase obj = rxn.getElementBySId("x");
      assertTrue( obj == null );
      obj = rxn.getElementByMetaId("meta28");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_LOCAL_PARAMETER );
      d = null;
    }

    public void test_GetMultipleObjects_noUnits()
    {
      SBMLReader reader = new SBMLReader();
      SBMLDocument d;
      string filename =  "../../sbml/test/test-data/";
      filename += "multiple-ids.xml";
      d = reader.readSBML(filename);
      if (d == null);
      {
      }
      SBase obj = d.getElementBySId("volume");
      assertTrue( obj == null );
      obj = d.getElementByMetaId("meta30");
      assertTrue( obj != null );
      assertTrue( obj.getTypeCode() == libsbml.SBML_UNIT_DEFINITION );
      d = null;
    }

  }
}
