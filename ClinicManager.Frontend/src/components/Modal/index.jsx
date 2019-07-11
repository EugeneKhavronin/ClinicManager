import React from 'react';
import Dialog from '@material-ui/core/Dialog';

const AlertDialog = ({ isOpen, handleClose, children }) => (
  <Dialog
    open={isOpen}
    onClose={handleClose}
    aria-labelledby="alert-dialog-title"
    aria-describedby="alert-dialog-description"
  >
    {children}
  </Dialog>
);

export default AlertDialog;
