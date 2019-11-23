import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import Collapse from '@material-ui/core/Collapse';
import InboxIcon from '@material-ui/icons/MoveToInbox';
import DraftsIcon from '@material-ui/icons/Drafts';
import SendIcon from '@material-ui/icons/Send';
import ExpandLess from '@material-ui/icons/ExpandLess';
import ExpandMore from '@material-ui/icons/ExpandMore';
import StarBorder from '@material-ui/icons/StarBorder';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import DataPerson from '../DataPerson';
import VisitsTable from '../VisitsTable/index';
import Grid from '@material-ui/core/Grid';
import Paper from '@material-ui/core/Paper';
import Chart from '../Diagram/index';
import clsx from 'clsx';
import EnhancedTable from '../AnaliseTable/index';
import PersonIcon from '@material-ui/icons/Person';
import PlaylistAddCheckIcon from '@material-ui/icons/PlaylistAddCheck';
import ColorizeIcon from '@material-ui/icons/Colorize';
import BarChartIcon from '@material-ui/icons/BarChart';
import AssignmentIcon from '@material-ui/icons/Assignment';
import BorderColorIcon from '@material-ui/icons/BorderColor';
import ChatIcon from '@material-ui/icons/Chat';
import LocationOnIcon from '@material-ui/icons/LocationOn';
import InsertDriveFileIcon from '@material-ui/icons/InsertDriveFile';
import DescriptionIcon from '@material-ui/icons/Description';
import EditForm from '../Cardio/index';
import FavoriteIcon from '@material-ui/icons/Favorite';

const useStyles = makeStyles(theme => ({
  root: {
    width: '100%',
    maxWidth: 360,
    height: 830,
    backgroundColor: theme.palette.background.paper,
    marginRight: 15
  },
  nested: {
    paddingLeft: theme.spacing(4)
  }
}));

export default function NestedList() {
  const classes = useStyles();
  const [openAnalise, setOpenAnalise] = React.useState(false);
  const [openDocument, setOpenDocument] = React.useState(false);
  const fixedHeightPaper = clsx(classes.paper, classes.fixedHeight);

  const handleClickAnalise = () => {
    setOpenAnalise(!openAnalise);
  };

  const handleClickDocument = () => {
    setOpenDocument(!openDocument);
  };

  return (
    <Router>
      <div style={{ display: 'flex' }}>
        <List
          component="nav"
          aria-labelledby="nested-list-subheader"
          className={classes.root}
        >
          <Link to="/">
            <ListItem button>
              <ListItemIcon>
                <PersonIcon />
              </ListItemIcon>
              <ListItemText primary="Личные данные" />
            </ListItem>
          </Link>

          <Link to="/visits">
            <ListItem button>
              <ListItemIcon>
                <PlaylistAddCheckIcon />
              </ListItemIcon>
              <ListItemText primary="Посещения" />
            </ListItem>
          </Link>

          <ListItem button onClick={handleClickAnalise}>
            <ListItemIcon>
              <ColorizeIcon />
            </ListItemIcon>
            <ListItemText primary="Анализы" />
            {openAnalise ? <ExpandLess /> : <ExpandMore />}
          </ListItem>

          <Collapse in={openAnalise} timeout="auto" unmountOnExit>
            <List component="div" disablePadding>
              <Link to="/table">
                <ListItem button className={classes.nested}>
                  <ListItemIcon>
                    <AssignmentIcon />
                  </ListItemIcon>
                  <ListItemText primary="Таблица" />
                </ListItem>
              </Link>

              <Link to="/diagram">
                <ListItem button className={classes.nested}>
                  <ListItemIcon>
                    <BarChartIcon />
                  </ListItemIcon>
                  <ListItemText primary="Диаграммы" />
                </ListItem>
              </Link>
            </List>
          </Collapse>

          <ListItem button>
            <ListItemIcon>
              <BorderColorIcon />
            </ListItemIcon>
            <ListItemText primary="Запись на приём" />
          </ListItem>

          <ListItem button>
            <ListItemIcon>
              <ChatIcon />
            </ListItemIcon>
            <ListItemText primary="Online консультация" />
          </ListItem>

          <Link to="/med">
            <ListItem button>
              <ListItemIcon>
                <LocationOnIcon />
              </ListItemIcon>
              <ListItemText primary="Медицинские организации" />
            </ListItem>
          </Link>

          <ListItem button onClick={handleClickDocument}>
            <ListItemIcon>
              <InsertDriveFileIcon />
            </ListItemIcon>
            <ListItemText primary="Документы" />
            {openDocument ? <ExpandLess /> : <ExpandMore />}
          </ListItem>

          <Collapse in={openDocument} timeout="auto" unmountOnExit>
            <List component="div" disablePadding>
              <ListItem button className={classes.nested}>
                <ListItemIcon>
                  <DescriptionIcon />
                </ListItemIcon>
                <ListItemText primary="Больничный" />
              </ListItem>

              <ListItem button className={classes.nested}>
                <ListItemIcon>
                  <DescriptionIcon />
                </ListItemIcon>
                <ListItemText primary="Выписной эпикриз" />
              </ListItem>

              <ListItem button className={classes.nested}>
                <ListItemIcon>
                  <DescriptionIcon />
                </ListItemIcon>
                <ListItemText primary="Справки" />
              </ListItem>
            </List>
          </Collapse>

          <Link to="/cardio">
            <ListItem button>
              <ListItemIcon>
                <FavoriteIcon />
              </ListItemIcon>
              <ListItemText primary="Кардио" />
            </ListItem>
          </Link>

        </List>

        <Switch>
          <Route exact path="/">
            <DataPerson />
          </Route>
          <Route path="/visits">
            <VisitsTable />
          </Route>
          <Route path="/table">
            <EnhancedTable />
          </Route>
          <Route path="/diagram">

          </Route>
          <Route path="/cardio">
            <EditForm />
          </Route>
        </Switch>
      </div>
    </Router>
  );
}
