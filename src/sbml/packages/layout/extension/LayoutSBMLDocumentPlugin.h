/**
 * @file:   LayoutSBMLDocumentPlugin.h
 * @brief:  Implementation of the LayoutSBMLDocumentPlugin class
 * @author: Generated by autocreate code
 *
 * <!--------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright (C) 2013-2014 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EMBL-EBI), Hinxton, UK
 *     3. University of Heidelberg, Heidelberg, Germany
 * 
 * Copyright (C) 2009-2013 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EMBL-EBI), Hinxton, UK
 *
 * Copyright (C) 2006-2008 by the California Institute of Technology,
 *     Pasadena, CA, USA 
 *
 * Copyright (C) 2002-2005 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. Japan Science and Technology Agency, Japan
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * ------------------------------------------------------------------------ -->
 *
 * @class LayoutSBMLDocumentPlugin
 * @sbmlbrief{layout} Extension of SBMLDocument.
 *
 * The LayoutSBMLDocumentPlugin class inherits from the SBMLDocumentPlugin
 * class, and codifies the extentions to the SBMLDocument class defined in
 * the SBML Level&nbsp;3 @ref layout "Layout" package ('layout').
 *
 * The LayoutSBMLDocumentPlugin defines a
 * required flag named <code>required</code>, which indicates whether the
 * 'fbc' constructs can be used to change the core mathematics of the
 * <code>&lt;model&gt;</code> child of the <code>&lt;sbml&gt;</code> element.
 * Because they can not, this attribute must be set @c false.
 */


#ifndef LayoutSBMLDocumentPlugin_H__
#define LayoutSBMLDocumentPlugin_H__


#include <sbml/common/extern.h>


#ifdef __cplusplus


#include <sbml/extension/SBMLDocumentPlugin.h>
#include <sbml/packages/layout/extension/LayoutExtension.h>
#include <sbml/util/IdList.h>


LIBSBML_CPP_NAMESPACE_BEGIN


class LIBSBML_EXTERN LayoutSBMLDocumentPlugin : public SBMLDocumentPlugin
{
public:

	/**
	 * Creates a new LayoutSBMLDocumentPlugin
	 */
	LayoutSBMLDocumentPlugin(const std::string& uri, const std::string& prefix, 
	                               LayoutPkgNamespaces* layoutns);


	/**
	 * Copy constructor for LayoutSBMLDocumentPlugin.
	 *
	 * @param orig; the LayoutSBMLDocumentPlugin instance to copy.
	 */
	LayoutSBMLDocumentPlugin(const LayoutSBMLDocumentPlugin& orig);


 	/**
	 * Assignment operator for LayoutSBMLDocumentPlugin.
	 *
	 * @param rhs; the object whose values are used as the basis
	 * of the assignment
	 */
	LayoutSBMLDocumentPlugin& operator=(const LayoutSBMLDocumentPlugin& rhs);


 	/**
	 * Creates and returns a deep copy of this LayoutSBMLDocumentPlugin object.
	 *
	 * @return a (deep) copy of this LayoutSBMLDocumentPlugin object.
	 */
	virtual LayoutSBMLDocumentPlugin* clone () const;


 	/**
	 * Destructor for LayoutSBMLDocumentPlugin.
	 */
	virtual ~LayoutSBMLDocumentPlugin();


 #ifndef SWIG

	/** @cond doxygenLibsbmlInternal */

	/**
	 * Reads the attributes of corresponding package in SBMLDocument element
	 */
	virtual void readAttributes (const XMLAttributes& attributes, 
	                             const ExpectedAttributes& expectedAttributes);


	/** @endcond */


#endif // SWIG

	/** @cond doxygenLibsbmlInternal */

	/**
	 * Returns boolean based on whether flattening of a comp model has been implemented.
	 *
	 * @returns @c true if flattening for composed models has been implemented,
	 * false otherwise.
	 */
	virtual bool isCompFlatteningImplemented() const;


	/** @endcond */


	/** @cond doxygenLibsbmlInternal */
	/**
	 * Check consistency function.
	 */
	virtual unsigned int checkConsistency();
	/** @endcond */


	/** @cond doxygenLibsbmlInternal */

	/**
	 * Accepts the SBMLVisitor.
	 */

  IdList getMetaidList() const;

  bool haveValidationListsBeenPopulated() const;

  void populateValidationLists();

  IdList getIdList() const;

  List * getListElementsWithId() const;

  /** @endcond */


protected:

	/** @cond doxygenLibsbmlInternal */

  IdList mMetaIdList;
  
  IdList mIdList;

  List* mElementsWithId;

  bool mValidationListsPopulated;
	
  
  /** @endcond */


};




LIBSBML_CPP_NAMESPACE_END


#endif /* __cplusplus */
#endif /* LayoutSBMLDocumentPlugin_H__ */


