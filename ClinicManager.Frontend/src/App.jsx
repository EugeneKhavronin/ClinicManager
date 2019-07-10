import React, { Component, Fragment } from 'react';

import { getClinics, createClinics, removeClinics } from './utils';
import ListClinic from './components/ListClinic';
import Header from './header';

import './header/header.css';
import './modal-window-more/modal-window-more.css';
import './index.css';

export default class App extends Component {
  state = {
    clinicData: [],
    isOpen: false
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

  handleDeleteItem = clinicGuid => {
    this.setState(({ clinicData }) => {
      const idx = clinicData.findIndex(el => el.clinicGuid === clinicGuid);

      const before = clinicData.slice(0, idx);
      const after = clinicData.slice(idx + 1);
      const newArray = [...before, ...after];
      return { clinicData: newArray };
    });
    removeClinics(clinicGuid).then(res => console.log('qwdqwd',res))
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
    const { clinicData, isOpen } = this.state;

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
          onDeleted={this.handleDeleteItem}
          onMore={this.onMore}
        />
      </Fragment>
    );
  }
}
