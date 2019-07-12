import React, { Component, Fragment } from 'react';
import DialogTitle from '@material-ui/core/DialogTitle';
import DialogContent from '@material-ui/core/DialogContent';
import Typography from '@material-ui/core/Typography';
import Button from "@material-ui/core/Button";

import { getClinics, createClinics, removeClinics, editClinic } from './utils';
import ListClinic from './components/ListClinic';
import Header from './header';
import { EditForm } from './components/Form';
import Modal from './components/Modal';

import './header/header.css';
import './modal-window-more/modal-window-more.css';
import './index.css';


export default class App extends Component {
  state = {
    clinicData: [],
    isOpen: false,
    isOpenEdit: false,
    isOpenMore: false,
    clinic: {}
  };

  componentDidMount() {
    getClinics.then(res => {
      this.setState({ clinicData: res.data });
    });
  }

  handleClickOpen = () => {
    this.setState({ isOpen: true });
  };

  handleClose = () => {
    this.setState({ isOpen: false });
  };

  handleClickOpenMore = clinicGuid => {
    const { clinicData } = this.state;
    const idx = clinicData.findIndex(el => el.clinicGuid === clinicGuid);
    this.setState({ isOpenMore: true, clinic: clinicData[idx] });
  };

  handleCloseMore = () => {
    this.setState({ isOpenMore: false, clinic: {} });
  };

  handleClickEdtOpen = clinicGuid => {
    const { clinicData } = this.state;
    const idx = clinicData.findIndex(el => el.clinicGuid === clinicGuid);
    this.setState({ isOpenEdit: true, clinic: clinicData[idx] });
  };

  handleEditClose = () => {
    this.setState({ isOpenEdit: false, clinic: {} });
  };

  handleDeleteItem = clinicGuid => {
    removeClinics(clinicGuid).then(res => {
      this.setState(({ clinicData }) => {
        const idx = clinicData.findIndex(el => el.clinicGuid === clinicGuid);

        const before = clinicData.slice(0, idx);
        const after = clinicData.slice(idx + 1);
        const newArray = [...before, ...after];
        return { clinicData: newArray };
      });
    });
  };

  submitEditClinic = values => {
    const { clinicData } = this.state;

    const clinicDataNew = clinicData.map(item => {
      if (item.clinicGuid === values.clinicGuid) {
        return values;
      }
      return item;
    });

    editClinic(values).then(res => {
      this.setState(state => ({
        ...state,
        clinicData: clinicDataNew,
        isOpenEdit: false
      }));
    });
  };

  submitCreateClinic = values => {
    createClinics(values).then(res => {
      this.setState(state => ({
        clinicData: state.clinicData.concat({
          ...values,
          clinicGuid: res.data
        }),
        isOpen: false
      }));
    });
  };

  render() {
    const { clinicData, isOpen, isOpenEdit, isOpenMore, clinic } = this.state;

    return (
      <Fragment>
        <Header
          isOpen={isOpen}
          handleClickOpen={this.handleClickOpen}
          handleClose={this.handleClose}
          submitCreateClinic={this.submitCreateClinic}
        />
        <ListClinic
          clinicData={clinicData}
          handleClickEditOpen={this.handleClickEdtOpen}
          onDeleted={this.handleDeleteItem}
          handleClickOpenMore={this.handleClickOpenMore}
        />
        <Modal isOpen={isOpenEdit} handleClose={this.handleEditClose}>
          <DialogTitle id="alert-dialog-title">
            Редактировать клинику
          </DialogTitle>
          <EditForm
            onSubmit={this.submitEditClinic}
            handleClose={this.handleEditClose}
            initialValues={clinic}
          />
        </Modal>
        <Modal isOpen={isOpenMore} handleClose={this.handleCloseMore}>
          <DialogTitle id="alert-dialog-title">
            {clinic.title && clinic.title}
          </DialogTitle>
          <DialogContent style={{ width: 600, marginBottom: 15 }}>
            <Typography variant="body2" color="textSecondary" component="p">
              Адрес:
              {clinic.email && clinic.email}
            </Typography>
            <Typography variant="body2" color="textSecondary" component="p">
              Email:
              <a href={`mailto:${clinic.email && clinic.email}`}>
                {clinic.email && clinic.email}
              </a>
            </Typography>
            <Typography variant="body2" color="textSecondary" component="p">
              Телефон:
              {clinic.phoneNumber && clinic.phoneNumber}
            </Typography>
            <Typography variant="body2" color="textSecondary" component="p">
              Специализация:
              {clinic.specialisation && clinic.specialisation}
            </Typography>
            <Typography variant="body2" color="textSecondary" component="p">
              URL:
              {clinic.url && clinic.url}
            </Typography>
          </DialogContent>
          <Button onClick={this.handleCloseMore} color="primary" autoFocus>
            Отменить
          </Button>
        </Modal>
      </Fragment>
    );
  }
}
